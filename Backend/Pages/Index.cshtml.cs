using Backend.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Backend.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public string Email { get; set; }
        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Email = HttpContext.User.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.Email.ToString())?.Value ?? "-";
            var user = await _context.Users.FirstOrDefaultAsync(_ => _.EmailAddress == Email);

            if (user == null)
            {
                return;
            }

            Name = user.Name;
        }
    }
}
