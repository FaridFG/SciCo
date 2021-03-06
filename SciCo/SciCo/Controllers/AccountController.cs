﻿using System;
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
            PostVM model = new PostVM
            {
                Posts = _db.Posts,
                Comments = _db.Comments,
                Likes = _db.Likes,
                Dislikes = _db.Dislikes,
                Photos = _db.Photos,
                Users = _db.Users
            };
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

        [AllowAnonymous]
        public async Task<IActionResult> Search(string search)
        {
            AppUser user = await _userManager.GetUserAsync(User);

            if (search == null)
            {
                ModelState.AddModelError("", "Type something to search");
                return View();
            }

            ViewBag.Fullname = search;
            ViewBag.Quantity = _db.Users.Where(s => (s != user) && (s.Name.Contains(search) || s.Surname.Contains(search))).Count();

            SearchVM model = new SearchVM
            {
                Users = _db.Users.Where(s => (s != user) && (s.Name.Contains(search) || s.Surname.Contains(search))).Take(5),
                Photos = _db.Photos
            };

            return View(model);
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
            //AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var friends = _db.Friends.Where(f => f.User1 == user || f.User2 == user).Select(f => f.Id);
            //foreach (int id in friends)
            //{
            //    Friend friend = await _db.Friends.FindAsync(id);
            //    _db.Friends.Remove(friend);
            //}

            //var friendRequests = _db.FriendRequests.Where(r => r.ReceiverUser == user || r.RequestorUser == user);
            //foreach (FriendRequest request in friendRequests)
            //{
            //    _db.FriendRequests.Remove(request);
            //}

            //var likes = _db.Likes.Where(l => l.Liker == user);
            //foreach (Like like in likes)
            //{
            //    _db.Likes.Remove(like);
            //}

            //var dislikes = _db.Dislikes.Where(d => d.Disliker == user);
            //foreach (Dislike dislike in dislikes)
            //{
            //    _db.Dislikes.Remove(dislike);
            //}

            //if (user == null)
            //{
            //    return NotFound();
            //}

            //return Content($"user = {user.UserName}, friends = {friends}");

            //await _signInManager.SignOutAsync();
            //_db.Users.Remove(user);
            //await _db.SaveChangesAsync();

            return RedirectToAction("Index", "User");
        }
    }
}