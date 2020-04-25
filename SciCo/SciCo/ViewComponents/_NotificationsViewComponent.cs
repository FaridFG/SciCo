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
                Posts = _db.Posts,
                Comments = _db.Comments,
                Likes = _db.Likes,
                Dislikes = _db.Dislikes,
                Users = _db.Users,
                Photos = _db.Photos
            };
            return View(await Task.FromResult(model));
        }
    }
}
