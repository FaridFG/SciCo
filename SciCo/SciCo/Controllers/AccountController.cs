using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Models;

namespace SciCo.Controllers
{
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
    }
}