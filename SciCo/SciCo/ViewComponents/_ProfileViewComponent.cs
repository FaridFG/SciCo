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
    public class _ProfileViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public _ProfileViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            return View(await Task.FromResult(user));
        }
    }
}
