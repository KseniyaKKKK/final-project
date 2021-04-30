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
        public PersonalCabinetController(UserManager<User> userManager,
            SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index(string id = null)
        {
            if (string.IsNullOrEmpty(id))
            {
                //id = User.Identity.GetUserId();
            }

            User t = userManager.FindByIdAsync(id).Result;
            return View(t);
        }


    }
}
