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
    public class FriendController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public FriendController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
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
                return View($"You '({RequestorUser.Name} {RequestorUser.Surname})' has already sent a friend request to '{ReceiverUser.Name} {ReceiverUser.Surname}'");
            }
            await _db.FriendRequests.AddAsync(request);
            await _db.SaveChangesAsync();
            return RedirectToAction("Timeline", "Account", new { id = ReceiverId });
        }

        public async Task<IActionResult> ShowFriendRequests()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            RequestsVM model = new RequestsVM()
            {
                ReceiverUser = user,
                RequestorUsers = _db.FriendRequests.Where(r => r.ReceiverUser == user).Select(r => r.RequestorUser)
            };
            return View(model);
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
            if((_db.Friends.Any(f => f.User1 == friend.User1 && f.User2 == friend.User2) || (_db.Friends.Any(f => f.User1 == friend.User2 && f.User2 == friend.User1)))){
                _db.FriendRequests.Remove(request);
                return Content("You are already friends");
            }
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

        public async Task<IActionResult> CancelFriendRequest(string ReceiverId)
        {
            AppUser RequestorUser = await _userManager.GetUserAsync(User);
            AppUser ReceiverUser = await _db.Users.FindAsync(ReceiverId);

            FriendRequest request = _db.FriendRequests.FirstOrDefault(r => r.RequestorUser == RequestorUser && r.ReceiverUser == ReceiverUser);

            _db.FriendRequests.Remove(request);
            await _db.SaveChangesAsync();
            return RedirectToAction("Timeline", "Account", new { id = ReceiverId });
        }

        public IActionResult Unfriend()
        {
            return View();
        }
    }
}