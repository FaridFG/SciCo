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

        public async Task<IActionResult> AcceptFriendRequest(int requestId, string requestorId)
        {
            FriendRequest request = await _db.FriendRequests.FindAsync(requestId);
            AppUser user = await _db.Users.FindAsync(requestorId);
            AppUser appUser = await _userManager.GetUserAsync(User);
            Friend friend = new Friend
            {
                User1 = user,
                User2 = appUser
            };
            await _db.Friends.AddAsync(friend);
            _db.FriendRequests.Remove(request);
            await _db.SaveChangesAsync();
            return RedirectToAction("Newsfeed", "Account");
        }

        public async Task<IActionResult> DeleteFriendRequest(int requestId)
        {
            FriendRequest request = await _db.FriendRequests.FindAsync(requestId);
            if (request == null)
            {
                return NotFound();
            }
            _db.FriendRequests.Remove(request);
            await _db.SaveChangesAsync();
            return RedirectToAction("Newsfeed", "Account");
        }
    }
}