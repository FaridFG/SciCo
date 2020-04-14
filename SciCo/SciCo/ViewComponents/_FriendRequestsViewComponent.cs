using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewComponents
{
    public class _FriendRequestsViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public _FriendRequestsViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var model = _db.FriendRequests.Where(r => r.ReceiverUser == user);
            ViewBag.Requestors = _db.FriendRequests.Select(r => r.RequestorUser);
            return View(await Task.FromResult(model));
        }
    }
}
