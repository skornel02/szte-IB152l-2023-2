
using Backend.Options;
using Backend.Persistance;
using Backend.Persistance.Entities;
using MailKit.Net.Smtp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Backend.BackgroundServices;

public class EmailBackgroundService : BackgroundService
{
    private readonly ILogger<EmailBackgroundService> _logger;
    private readonly IOptionsMonitor<EmailOptions> _emailOptions;
    private readonly IServiceProvider _serviceProvider;

    public EmailBackgroundService(
        ILogger<EmailBackgroundService> logger,
        IOptionsMonitor<EmailOptions> emailOptions,
        IServiceProvider serviceProvider)
    {
        _logger = logger;
        _emailOptions = emailOptions;
        _serviceProvider = serviceProvider;
    }


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Email background service is starting");
        while (!stoppingToken.IsCancellationRequested)
        {
            var options = _emailOptions.CurrentValue;
            await Task.Delay(TimeSpan.FromSeconds(options.TickIntervalInSeconds), stoppingToken);

            var now = DateTime.Now;

            try
            {
                List<EmailQueueEntity> emails;

                await using(var scope = _serviceProvider.CreateAsyncScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    emails = await context.Emails
                        .AsNoTracking()
                        .Where(e => e.SentAt == null)
                        .OrderByDescending(e => e.Priority)
                        .ThenBy(e => e.CreatedAt)
                        .Take(options.EmailBatchSize)
                        .ToListAsync(stoppingToken);
                }

                if (emails.Count == 0)
                {
                    continue;
                }

                var messages = emails.ToDictionary(_ => _, _ =>
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(options.SenderName, options.SenderEmailAddress));
                    message.To.Add(new MailboxAddress("Alko user", _.RecipientUserEmailAddress));
                    message.Subject = _.Title;

                    message.Body = new TextPart("plain")
                    {
                        Text = _.Content
                    };

                    return message;
                });

                _logger.LogInformation("Sending {count} emails", messages.Count);

                using var client = new SmtpClient();
                await client.ConnectAsync(options.SmtpServer, options.SmtpPort, options.SmtpUseSsl, stoppingToken);

                if (options.SmtpUseAuthentication)
                {
                    await client.AuthenticateAsync(options.SmtpUsername, options.SmtpPassword, stoppingToken);
                }

                var sentEmails = new List<EmailQueueEntity>();
                foreach (var (email, message) in messages)
                {
                    try { 
                        await client.SendAsync(message);
                        sentEmails.Add(email);
                    } 
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Error occurred during email sending with id: '{}'", email.Id);
                    }
                }

                await client.DisconnectAsync(true, stoppingToken);

                if (sentEmails.Count == 0)
                {
                    continue;
                }

                await using (var scope = _serviceProvider.CreateAsyncScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    var sentEmailIds = sentEmails.Select(e => e.Id).ToList();
                    await context.Emails.Where(_ => sentEmailIds.Contains(_.Id))
                        .ExecuteUpdateAsync(_ => _.SetProperty(_ => _.SentAt, now));
                }
            } 
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during email sending");
            }
        }
        _logger.LogInformation("Email background service is stopping");
    }
}
