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
            RequestsVM model = new RequestsVM()
            {
                ReceiverUser = user,
                RequestorUsers = _db.FriendRequests.Where(r => r.ReceiverUser == user).Select(r => r.RequestorUser)
            };
            //ViewBag.Requestors = _db.FriendRequests.Where(r => r.ReceiverUser == user).Select(r => r.RequestorUser);
            return View(await Task.FromResult(model));
        }
    }
}
