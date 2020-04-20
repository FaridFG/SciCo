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
    public class AccountInfoController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public AccountInfoController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IActionResult> UpdateHometown(string hometown)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            
            if(hometown == null || hometown.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            user.Hometown = hometown;
            await _db.SaveChangesAsync();
            return RedirectToAction("About", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> UpdateCurrentCity(string currentCity)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (currentCity == null || currentCity.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            user.CurrentCity = currentCity;
            await _db.SaveChangesAsync();
            return RedirectToAction("About", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> UpdateGender(string gender)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (gender == null || gender.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            user.Gender = gender;
            await _db.SaveChangesAsync();
            return RedirectToAction("About", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> UpdateEducation(string education)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (education == null || education.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            user.Education = education;
            await _db.SaveChangesAsync();
            return RedirectToAction("About", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> UpdateEmail(string email)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (email == null || email.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            user.Email = email;
            await _db.SaveChangesAsync();
            return RedirectToAction("About", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> UpdatePhoneNumber(string number)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (number == null || number.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            user.PhoneNumber = number;
            await _db.SaveChangesAsync();
            return RedirectToAction("About", "Account", new { id = user.Id });
        }

        public async Task<IActionResult> UpdateProfilePhoto(string profilePhoto)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if(profilePhoto == null || profilePhoto.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            return View();
        }

        public async Task<IActionResult> UpdateCoverPhoto(string coverPhoto)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (coverPhoto == null || coverPhoto.Trim() == "")
            {
                return PartialView("_ValidationError");
            }

            return View();
        }
    }
}