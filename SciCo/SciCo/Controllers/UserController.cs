using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;

namespace SciCo.Controllers
{
    public class UserController : Controller
    {
        protected ApplicationDbContext _context;
        protected UserManager<ApplicationUser> _userManager;
        protected SignInManager<ApplicationUser> _signInManager;
        public UserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //private RoleManager<IdentityRole> _roleManager;
        //public UserController(RoleManager<IdentityRole> roleManager)
        //{
        //    _roleManager = roleManager;
        //}

        //public async Task RoleSeed()
        //{
        //    if (!await _roleManager.RoleExistsAsync(UserRoles.AdminRole))
        //        await _roleManager.CreateAsync(new IdentityRole(UserRoles.AdminRole));
        //    if (!await _roleManager.RoleExistsAsync(UserRoles.ManagerRole))
        //        await _roleManager.CreateAsync(new IdentityRole(UserRoles.ManagerRole));
        //    if (!await _roleManager.RoleExistsAsync(UserRoles.MemberRole))
        //        await _roleManager.CreateAsync(new IdentityRole(UserRoles.MemberRole));
        //}

        public IActionResult Index()
        {
            _context.Database.EnsureCreated();

            if (!_context.Settings.Any())
            {
                _context.Settings.Add(new SettingsDataModel
                {
                    Name = "BackgroundColor",
                    Value = "Red"
                });

                var settingsLocally = _context.Settings.Local.Count();
                var settingsDatabase = _context.Settings.Count();
                var firstLocal = _context.Settings.Local.FirstOrDefault();
                var firstDatabase = _context.Settings.FirstOrDefault();

                _context.SaveChanges();

                settingsLocally = _context.Settings.Local.Count();
                settingsDatabase = _context.Settings.Count();
                firstLocal = _context.Settings.Local.FirstOrDefault();
                firstDatabase = _context.Settings.FirstOrDefault();
            }
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        //public async Task<IActionResult> LogOut()
        //{
        //    await _signInManager.SignOutAsync();
        //    return RedirectToAction("Index", "User");
        //}
    }
}