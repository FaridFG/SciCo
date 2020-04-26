using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Helpers;
using SciCo.Models;

namespace SciCo.Areas.AdminPage.Controllers
{
    [Area("AdminPage")]
    [Authorize(Roles = UserRoles.AdminRole)]
    public class UpdateUserController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public UpdateUserController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var model = _db.Users.Where(u => u != user);
            return View(model);
        }

        public async Task<IActionResult> UpdateUserInfo(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            ViewBag.UserRole = await _userManager.GetRolesAsync(user);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUserInformation(string id, string userEmail, string userName, string userRole)
        {
            AppUser user = await _db.Users.FindAsync(id);

            if (user == null)
            {
                return View("ErrorView");
            }

            if(userEmail == null || userEmail == "" || userName == null || userName == "" || userRole == null || userRole == "")
            {
                return View("ErrorView");
            }

            user.Email = userEmail;
            user.UserName = userName;
            var role = _db.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);
            _db.UserRoles.Remove(role);
            await _userManager.AddToRoleAsync(user, userRole);
            _userManager.GenerateNewAuthenticatorKey();
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", "UpdateUser", new { id = id });
        }
    }
}