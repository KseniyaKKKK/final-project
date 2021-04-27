﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Kursach.Models;

namespace Kursach.Controllers
{
    public class AdminController : Controller
    {
        RoleManager<IdentityRole> roleManager;
        UserManager<User> userManager;
        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = userManager.Users;
            return View(users);
        }

        //public IActionResult Create() => View();
        //[HttpPost]
        //public async Task<IActionResult> Create(string name)
        //{
        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            foreach (var error in result.Errors)
        //            {
        //                ModelState.AddModelError(string.Empty, error.Description);
        //            }
        //        }
        //    }
        //    return View(name);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Delete(string id)
        //{
        //    IdentityRole role = await roleManager.FindByIdAsync(id);
        //    if (role != null)
        //    {
        //        IdentityResult result = await roleManager.DeleteAsync(role);
        //    }
        //    return RedirectToAction("Index");
        //}

        //public IActionResult UserList() => View(userManager.Users.ToList());

        //public async Task<IActionResult> Edit(string userId)
        //{
        //    // получаем пользователя
        //    User user = await userManager.FindByIdAsync(userId);
        //    if (user != null)
        //    {
        //        // получем список ролей пользователя
        //        var userRoles = await userManager.GetRolesAsync(user);
        //        var allRoles = roleManager.Roles.ToList();
        //        ChangeRoleModel model = new ChangeRoleModel
        //        {
        //            UserId = user.Id,
        //            UserEmail = user.Email,
        //            UserRoles = userRoles,
        //            AllRoles = allRoles
        //        };
        //        return View(model);
        //    }

        //    return NotFound();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Edit(string userId, List<string> roles)
        //{
        //    // получаем пользователя
        //    User user = await userManager.FindByIdAsync(userId);
        //    if (user != null)
        //    {
        //        // получем список ролей пользователя
        //        var userRoles = await userManager.GetRolesAsync(user);
        //        // получаем все роли
        //        var allRoles = roleManager.Roles.ToList();
        //        // получаем список ролей, которые были добавлены
        //        var addedRoles = roles.Except(userRoles);
        //        // получаем роли, которые были удалены
        //        var removedRoles = userRoles.Except(roles);

        //        await userManager.AddToRolesAsync(user, addedRoles);

        //        await userManager.RemoveFromRolesAsync(user, removedRoles);

        //        return RedirectToAction("UserList");
        //    }

        //    return NotFound();
        //}
    }
}

