using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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

        public async Task<IActionResult> AddPhoto(IFormFile image)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (image == null)
            {
                return View("_ValidationError");
            }

            if (!image.IsImage())
            {
                return Content("please, select an image");
            }

            if (image.LessThan(0.75))
            {
                return Content("size is too large");
            }

            string fileName = await image.SavePhoto(_env.WebRootPath, "img");

            Photo photo = new Photo
            {
                user = user,
                Link = fileName,
                isProfilePhoto = false,
                isCoverPhoto = false
            };

            await _db.Photos.AddAsync(photo);
            await _db.SaveChangesAsync();
            return RedirectToAction("Timeline", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> AddProfilePhoto(IFormFile ProfileImage)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (ProfileImage == null)
            {
                return View("_ValidationError");
            }

            if (!ProfileImage.IsImage())
            {
                return Content("please, select an image");
            }

            if (ProfileImage.LessThan(0.75))
            {
                return Content("size is too large");
            }

            string fileName = await ProfileImage.SavePhoto(_env.WebRootPath, "img");

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

        public async Task<IActionResult> AddCoverPhoto(IFormFile CoverImage)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (CoverImage == null)
            {
                return View("_ValidationError");
            }

            if (!CoverImage.IsImage())
            {
                return Content("please, select an image");
            }

            if (CoverImage.LessThan(0.75))
            {
                return Content("size is too large");
            }

            string fileName = await CoverImage.SavePhoto(_env.WebRootPath, "img");

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