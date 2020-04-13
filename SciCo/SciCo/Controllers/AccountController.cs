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
        public AccountController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Newsfeed()
        {
            return View();
        }

        public async Task<IActionResult> Timeline(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            return View(user);
        }

        public async Task<IActionResult> About(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
            return View(user);
        }

        public async Task<IActionResult> Friends(string id)
        {
            AppUser user = await _db.Users.FindAsync(id);
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
    }
}