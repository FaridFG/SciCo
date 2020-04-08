using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SciCo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Newsfeed()
        {
            return View();
        }
    }
}