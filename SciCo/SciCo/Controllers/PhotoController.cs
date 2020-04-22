using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SciCo.Data;
using SciCo.Helpers;
using SciCo.Models;

namespace SciCo.Controllers
{
    public class PhotoController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;

        public PhotoController(AppDbContext db, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _db = db;
            _userManager = userManager;
            _env = env;
        }

        public IActionResult AddPhoto(IFormFile image)
        {
            return View();
        }

        public async Task<IActionResult> AddProfilePhoto(IFormFile firstProfileImage)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (firstProfileImage == null)
            {
                return View("_ValidationError");
            }

            if (!firstProfileImage.IsImage())
            {
                return Content("please, select an image");
            }

            if (firstProfileImage.LessThan(0.75))
            {
                return Content("size is too large");
            }

            string fileName = await firstProfileImage.SavePhoto(_env.WebRootPath, "img");

            Photo profilePhoto = new Photo
            {
                user = user,
                Link = fileName,
                isProfilePhoto = true,
                isCoverPhoto = false
            };

            await _db.Photos.AddAsync(profilePhoto);
            await _db.SaveChangesAsync();
            return RedirectToAction("Timeline", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> AddCoverPhoto(IFormFile firstCoverImage)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (firstCoverImage == null)
            {
                return View("_ValidationError");
            }

            if (!firstCoverImage.IsImage())
            {
                return Content("please, select an image");
            }

            if (firstCoverImage.LessThan(0.75))
            {
                return Content("size is too large");
            }

            string fileName = await firstCoverImage.SavePhoto(_env.WebRootPath, "img");

            Photo coverPhoto = new Photo
            {
                user = user,
                Link = fileName,
                isProfilePhoto = false,
                isCoverPhoto = true
            };

            await _db.Photos.AddAsync(coverPhoto);
            await _db.SaveChangesAsync();
            return RedirectToAction("Timeline", "Account", new { id = user.Id });
        }
    }
}