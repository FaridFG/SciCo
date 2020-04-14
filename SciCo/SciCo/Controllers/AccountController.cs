using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Models;

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
            var model = new List<FriendRequest>();
            return View(model);
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
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public IActionResult Photos()
        {
            return View();
        }

        public IActionResult Videos()
        {
            return View();
        }

        public IActionResult Search(string search)
        {
            if (search == null)
            {
                ModelState.AddModelError("", "Type something to search");
                return View();
            }
            return View(_db.Users.Where(s => s.Name.Contains(search) || s.Surname.Contains(search)).Take(5));
        }

        [HttpPost]
        public async Task<IActionResult> ShowProfile(string userId)
        {
            AppUser user = await _db.Users.FindAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> SendFriendRequest(string ReceiverId)
        {
            AppUser RequestorUser = await _userManager.GetUserAsync(User);
            AppUser ReceiverUser = await _db.Users.FindAsync(ReceiverId);
            
            FriendRequest request = new FriendRequest
            {
                RequestorUser = RequestorUser,
                ReceiverUser = ReceiverUser
            };

            if (_db.FriendRequests.Any(r => r.RequestorUser == RequestorUser && r.ReceiverUser == ReceiverUser))
            {
                return Content($"You '({RequestorUser.Name} {RequestorUser.Surname})' has already sent a friend request to '{ReceiverUser.Name} {ReceiverUser.Surname}'");
            }
            await _db.FriendRequests.AddAsync(request);
            await _db.SaveChangesAsync();
            return Content($"You '({RequestorUser.Name} {RequestorUser.Surname})' has sent a friend request to '{ReceiverUser.Name} {ReceiverUser.Surname}'");
        }

        public IActionResult AcceptFriendRequest()
        {
            return View();
        }

        public IActionResult AddInfo(string input)
        {
            return View();
        }
    }
}