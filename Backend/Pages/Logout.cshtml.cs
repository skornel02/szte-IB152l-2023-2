using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Backend.Pages;

public class LogoutModel : PageModel
{
    public async Task OnGetAsync()
    {
        try
        {
            await HttpContext.SignOutAsync();
        } catch (Exception)
        {
            // ignored
        }

        RedirectToRoute("/Login");
    }
}
