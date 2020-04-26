using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Areas.AdminPage.ViewModels;
using SciCo.Data;
using SciCo.Helpers;
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

        public async Task<IActionResult> Info(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            return View(user);
        }

        public async Task<IActionResult> ShowFriends(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);

            ShowFriendVM model = new ShowFriendVM
            {
                MainUser = user,
                Users = _db.Users,
                Friends = _db.Friends
            };

            return View(model);
        }

        public async Task<IActionResult> ShowPhotos(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);

            UserPhotoVM model = new UserPhotoVM
            {
                MainUser = user,
                Photos = _db.Photos,
                Users = _db.Users
            };

            return View(model);
        }

        [Authorize(Roles = UserRoles.AdminRole)]
        public async Task<IActionResult> ShowMessages(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);

            ShowMessageVM model = new ShowMessageVM
            {
                MainUser = user,
                Sender = _db.Users,
                Messages = _db.Messages
            };

            return View(model);
        }

        public async Task<IActionResult> ShowComments(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);

            UserCommentsVM model = new UserCommentsVM
            {
                MainUser = user,
                Comments = _db.Comments,
                Posts = _db.Posts,
                Users = _db.Users
            };

            return View(model);
        }

        public async Task<IActionResult> ShowLikes(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);

            UserLikesVM model = new UserLikesVM
            {
                MainUser = user,
                Users = _db.Users,
                Posts = _db.Posts,
                Likes = _db.Likes
            };

            return View(model);
        }

        public async Task<IActionResult> ShowDislikes(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);

            UserDislikeVM model = new UserDislikeVM
            {
                MainUser = user,
                Users = _db.Users,
                Posts = _db.Posts,
                Dislikes = _db.Dislikes
            };

            return View(model);
        }
    }
}