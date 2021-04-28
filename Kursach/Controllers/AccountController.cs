using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Kursach.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UserManager.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet, AllowAnonymous]
        public IActionResult Register()
        {
            UserRegister model = new UserRegister();
            return View(model);
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Register(UserRegister request)
        {
            if (ModelState.IsValid)
            {
                var userCheck = await userManager.FindByEmailAsync(request.Email);
                if (userCheck == null)
                {
                    var user = new User
                    {
                        Name = request.Name,
                        Email = request.Email,
                        UserName = request.Email,
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user, request.Password);
                    await userManager.AddToRoleAsync(user, "User");
                    await userManager.AddToRoleAsync(user, "Admin");
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        if (result.Errors.Count() > 0)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("message", error.Description);
                            }
                        }
                        return View(request);
                    }
                }
                else
                {
                    ModelState.AddModelError("message", "Email already exists.");
                    return View(request);
                }
            }

            return View(request);

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            UserLogin model = new UserLogin();
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLogin model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);

                if (await userManager.CheckPasswordAsync(user, model.Password) == false)
                {
                    ModelState.AddModelError("message", "Invalid credentials");
                    return View(model);

                }

                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    await userManager.AddClaimAsync(user, new Claim("UserRole", "Admin"));
                    return RedirectToAction("Index", "PersonalCabinet");
                }
                else if (result.IsLockedOut)
                {
                    return View("AccountLocked");
                }
                else
                {
                    ModelState.AddModelError("message", "Invalid login attempt");
                    return View(model);
                }
            }

            return View(model);
        }

        [HttpGet, Route("Account/ExternalLogin")]
        public IActionResult ExternalLogin(string returnUrl, string provider = "google")
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account",
                new { ReturnUrl = returnUrl });

            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return new ChallengeResult(provider, properties);
        }


        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return View("Login");
            }

            var signInResul = signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey,
                isPersistent: false, bypassTwoFactor: false);
            if (signInResul.Result.Succeeded)
            {
                return RedirectToAction("Index", "PersonalCabinet");
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if (email != null)
                {
                    var user = await userManager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new User
                        {
                            Name = info.Principal.FindFirstValue(ClaimTypes.Name),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email)
                        };

                        await userManager.CreateAsync(user);
                    }

                    await userManager.AddLoginAsync(user, info);
                    await signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "PersonalCabinet", user);
                }
            }

            return View("Home");
        }

    }
}

