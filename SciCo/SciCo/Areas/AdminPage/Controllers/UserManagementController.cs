using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Models;

namespace SciCo.Areas.AdminPage.Controllers
{
    [Area("AdminPage")]
    [Authorize]
    public class UserManagementController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public UserManagementController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IActionResult> Users()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var model = _db.Users.Where(u => u != user);
            return View(model);
        }

        public IActionResult Update()
        {
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            return View(user);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var role = _db.UserRoles.FirstOrDefault(ur => ur.UserId == user.Id);
            if (role == null)
            {
                return NotFound();
            }

            foreach (FriendRequest request in _db.FriendRequests)
            {
                if(request.ReceiverUser == user || request.RequestorUser == user)
                {
                    _db.FriendRequests.Remove(request);
                }
            }

            _db.UserRoles.Remove(role);
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
            return RedirectToAction("Users");
        }
    }
}