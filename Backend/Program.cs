using Backend.Persistance;
using Backend.Persistance.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(_ => _
    .UseOracle(builder.Configuration.GetConnectionString("Oracle"))
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors());

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(_ =>
    {
        _.LoginPath = "/Login";
        _.LogoutPath = "/Logout";
    });
builder.Services.AddAuthorization();

builder.Services.AddScoped<PasswordHasher<UserEntity>>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await context.Database.MigrateAsync();
}

app.Run();
