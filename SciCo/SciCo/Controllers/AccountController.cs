using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;

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
            var model = _db.LeftAsides;
            return View(model);
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