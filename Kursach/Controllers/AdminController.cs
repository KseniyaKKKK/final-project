using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Kursach.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kursach.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        RoleManager<IdentityRole> roleManager;
        UserManager<User> userManager;
        SignInManager<User> signInManager;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string SelectedCheckbox)
        {
            var currentId = userManager.GetUserId(this.User);
            var SplitedValues = SelectedCheckbox.ToString().Split(',');
            foreach (string id in SplitedValues)
            {
                User user = await userManager.FindByIdAsync(id);
                if (user != null)
                {
                    if (userManager.GetRolesAsync(user).Result.Count(x => x == "Admin") != 1)
                    {
                        await userManager.DeleteAsync(user);
                        if (currentId == id)
                        {
                            await signInManager.SignOutAsync();
                        }
                    }
                }
            }

            return RedirectToAction("index", "Admin", userManager.Users);
        }

        [HttpPost("{SelectedChecknox}", Name = "Block")]
        public async Task<IActionResult> Block(string SelectedCheckbox)
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var currentId = userManager.GetUserId(currentUser);
            var SplitedValues = SelectedCheckbox.ToString().Split(',');
            foreach (string id in SplitedValues)
            {
                User user = await userManager.FindByIdAsync(id);
                if (user != null)
                {
                    if (userManager.GetRolesAsync(user).Result.Count(x => x == "Admin") != 1)
                    {
                        user.Status = StatusType.Blocked;
                        await userManager.UpdateAsync(user);
                        if (currentId == id)
                        {
                            await signInManager.SignOutAsync();
                        }
                    }
                    
                }
            }

            return RedirectToAction("index", "Admin", userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> Unblock(string SelectedCheckbox)
        {
            var SplitedValues = SelectedCheckbox.ToString().Split(',');
            foreach (string id in SplitedValues)
            {
                User user = await userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.Status = StatusType.Unblocked;
                    await userManager.UpdateAsync(user);
                }
            }

            return RedirectToAction("index", "Admin", userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string SelectedCheckbox)
        {
            var SplitedValues = SelectedCheckbox.ToString().Split(',');
            foreach (string id in SplitedValues)
            {
                User user = await userManager.FindByIdAsync(id);
                if (user != null)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }

            return RedirectToAction("index", "Admin", userManager.Users);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string SelectedCheckbox)
        {
            var SplitedValues = SelectedCheckbox.ToString().Split(',');
            foreach (string id in SplitedValues)
            {
                User user = await userManager.FindByIdAsync(id);
                if (user != null)
                {
                    await userManager.RemoveFromRoleAsync(user, "Admin");
                }
            }

            return RedirectToAction("index", "Admin", userManager.Users);
        }
    }
}

