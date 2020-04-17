using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Models;
using SciCo.ViewModels;

namespace SciCo.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Newsfeed()
        {
            return View();
        }

        public async Task<IActionResult> Timeline(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Search(string search)
        {
            AppUser user = await _userManager.GetUserAsync(User);
            ViewBag.Fullname = search;
            ViewBag.Quantity = _db.Users.Where(s => (s != user) && (s.Name.Contains(search) || s.Surname.Contains(search))).Count();
            if (search == null)
            {
                ModelState.AddModelError("", "Type something to search");
                return View();
            }
            return View(_db.Users.Where(s => (s != user) && (s.Name.Contains(search) || s.Surname.Contains(search))).Take(5));
        }

        public async Task<IActionResult> ShowProfile(string userId)
        {
            AppUser user = await _db.Users.FindAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            return View("Timeline", user);
        }

        public async Task<IActionResult> About(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public async Task<IActionResult> Friends(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            FriendVM model = new FriendVM
            {
                MainUser = user,
                Friends = _db.Friends.Where(f => f.User1 == user || f.User2 == user)
            };
            return View(model);
        }
    }
}