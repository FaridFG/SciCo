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
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(AppDbContext db, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
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

        public async Task<IActionResult> Next(string search, int? page)
        {
            AppUser user = await _userManager.GetUserAsync(User);
            ViewBag.PageCount = Math.Ceiling((decimal)(_db.Users.Where(s => (s != user) && (s.Name.Contains(search) || s.Surname.Contains(search))).Count()));
            if (page == null)
            {
                return View(_db.Users.Where(s => (s != user) && (s.Name.Contains(search) || s.Surname.Contains(search))).Take(5));
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
                FriendUsers = _db.Friends.Where(f => f.User1 == user).Select(f => f.User2).Concat(_db.Friends.Where(f => f.User2 == user).Select(f => f.User1)),
                Friends = _db.Friends.Where(f => f.User1.Id == user.Id || f.User2.Id == user.Id),
                Photos = _db.Photos
            };
            return View(model);
        }

        public async Task<IActionResult> Photos(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            PhotoVM model = new PhotoVM
            {
                user = user,
                Photos = _db.Photos.Where(p => p.user == user)
            };
            return View(model);
        }

        public async Task<IActionResult> DeleteAccount()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var friends = _db.Friends.Where(f => f.User1 == user || f.User2 == user).Select(f => f.Id);

            if (user == null)
            {
                return NotFound();
            }

            return Content($"user = {user.UserName}, friends = {friends}");

            //await _signInManager.SignOutAsync();
            //_db.Users.Remove(user);
            //await _db.SaveChangesAsync();

            //return RedirectToAction("Index", "User");
        }
    }
}