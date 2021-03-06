using Kursach.Data;
using Kursach.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Kursach.Controllers
{
    public class PersonalCabinetController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public static ApplicationDbContext context;
        public PersonalCabinetController(ApplicationDbContext _context, UserManager<User> userManager,
            SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            context = _context;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index(string id)
        {
            User t = userManager.FindByIdAsync(id).Result;
            return View(t);
        }


    }
}
