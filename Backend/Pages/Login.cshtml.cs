using Backend.Persistance;
using Backend.Persistance.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Claims;

namespace Backend.Pages;

public enum LoginIntention
{
    Login,
    Register
}

public class LoginModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly PasswordHasher<UserEntity> _passwordHasher;

    public string? DisplayMessage { get; set; } = default!;

    [BindProperty]
    [Display(Name = "E-mail")]
    [StringLength(256)]
    [EmailAddress]
    public string LoginEmail { get; set; } = default!;

    [BindProperty]
    [Display(Name = "Password")]
    [StringLength(128, MinimumLength = 6)]
    public string LoginPassword { get; set; } = default!;

    [BindProperty]
    [Display(Name = "E-mail")]
    [StringLength(256)]
    [EmailAddress]
    public string RegisterEmail { get; set; } = default!;

    [BindProperty]
    [Display(Name = "Password")]
    [StringLength(128, MinimumLength = 6)]
    public string RegisterPassword { get; set; } = default!;

    [BindProperty]
    [Display(Name = "Password confirmation")]
    [StringLength(128, MinimumLength = 6)]
    public string RegisterPasswordConfirmation { get; set; } = default!;

    [BindProperty]
    public LoginIntention Intention { get; set; }

    public LoginModel(ApplicationDbContext context, PasswordHasher<UserEntity> passwordHasher)
    {
        _context = context;
        _passwordHasher = passwordHasher;
    }

    public void OnGet()
    {
        DisplayMessage = "Welcome to the login page! Please login or register.";

        if (User.Identity?.IsAuthenticated ?? false)
        {
            Response.Redirect("/");
        }
    }

    public async Task OnPostAsync()
    {
        var existingUser = await _context.Users
            .FirstOrDefaultAsync(_ => _.EmailAddress == LoginEmail);

        if (Intention == LoginIntention.Login)
        {
            ModelState.RemoveAll<LoginModel>(_ => _.RegisterEmail);
            ModelState.RemoveAll<LoginModel>(_ => _.RegisterPassword);
            ModelState.RemoveAll<LoginModel>(_ => _.RegisterPasswordConfirmation);

            if (existingUser is null)
            {
                ModelState.AddModelError<LoginModel>(_ => _.LoginEmail, "User does not exist!");
                return;
            }

            if (_passwordHasher.VerifyHashedPassword(existingUser, existingUser.PasswordHash, LoginPassword) == PasswordVerificationResult.Failed)
            {
                ModelState.AddModelError<LoginModel>(_ => _.LoginPassword, "Invalid password!");
                return;
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, existingUser.EmailAddress),
            };

            await HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme)));
        } else
        {
            ModelState.RemoveAll<LoginModel>(_ => _.LoginEmail);
            ModelState.RemoveAll<LoginModel>(_ => _.LoginPassword);

            if (RegisterPassword != RegisterPasswordConfirmation)
            {
                ModelState.AddModelError<LoginModel>(_ => _.RegisterPasswordConfirmation, "Passwords do not match!");
                return;
            }

            if (existingUser is not null)
            {
                ModelState.AddModelError<LoginModel>(_ => _.RegisterEmail, "User already exists!");
                return;
            }

            var newUser = new UserEntity
            {
                EmailAddress = RegisterEmail,
                PasswordHash = _passwordHasher.HashPassword(null, RegisterPassword),
                FirstName = "first",
                LastName = "name",
                MiddleName = "middle",
                Pronouns = "pronouns",
                UserWatcher = false,
            };

            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();

            DisplayMessage = "You registrated successfully! Now please log in!";
        }
    }
}
