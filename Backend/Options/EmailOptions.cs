namespace Backend.Options;

public class EmailOptions
{
    public const string SectionName = "Email";

    public int TickIntervalInSeconds { get; set; } = 10;
    public int EmailBatchSize { get; set; } = 10;

    public string SmtpServer { get; set; } = "localhost";
    public int SmtpPort { get; set; } = 25;
    public bool SmtpUseSsl { get; set; } = false;

    public bool SmtpUseAuthentication { get; set; } = false;
    public string SmtpUsername { get; set; } = "test";
    public string SmtpPassword { get; set; } = "testtestest";

    public string SenderName { get; set; } = "ALKO";
    public string SenderEmailAddress { get; set; } = "no-reply@alko.hu";
}
