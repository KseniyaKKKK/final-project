using System.Threading.Tasks;
using Kursach.Data;
using Kursach.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Kursach.Controllers
{
    public class CampaignController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public static ApplicationDbContext context;
        public CampaignController(ApplicationDbContext _context, UserManager<User> userManager,
            SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            context = _context;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Create()
        {
            Campaign model = new Campaign();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Campaign request)
        {
            return RedirectToAction("Index", "PersonalCabinet", userManager.FindByNameAsync(User.Identity.Name).Result);
        }
    }
}