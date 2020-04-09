using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Helpers;
using SciCo.Models;
using SciCo.ViewModels;

namespace SciCo.Controllers
{
    public class UserController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task RoleSeed()
        {
            if (!await _roleManager.RoleExistsAsync(UserRoles.AdminRole))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.AdminRole));
            if (!await _roleManager.RoleExistsAsync(UserRoles.ManagerRole))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.ManagerRole));
            if (!await _roleManager.RoleExistsAsync(UserRoles.MemberRole))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.MemberRole));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpVM user)
        {
            if (!ModelState.IsValid) return View(user);

            AppUser appUser = new AppUser
            {
                Name = user.Name,
                Surname = user.Surname,
                UserName = user.Username,
                Email = user.Email,
                Birthday = user.Birthday
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(user);
            }

            await _userManager.AddToRoleAsync(appUser, UserRoles.AdminRole);
            await _signInManager.SignInAsync(appUser, true);

            return RedirectToAction("Newsfeed", "Account");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM user)
        {
            if (!ModelState.IsValid) return View("Index", user);

            AppUser appUser = await _userManager.FindByEmailAsync(user.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View("Index", user);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, user.Password, user.RememberMe, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View("Index", user);
            }

            return RedirectToAction("Newsfeed", "Account");
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "User");
        }
    }
}