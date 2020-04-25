using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Models;
using SciCo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewComponents
{
    public class _NotificationsViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public _NotificationsViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            PostVM model = new PostVM()
            {
                Posts = _db.Posts.Where(p => p.Poster == user),
                Comments = _db.Comments.Where(c => c.Commenter != user),
                Likes = _db.Likes.Where(l => l.Liker != user),
                Dislikes = _db.Dislikes.Where(d => d.Disliker != user),
                Users = _db.Users,
                Photos = _db.Photos
            };
            return View(await Task.FromResult(model));
        }
    }
}
