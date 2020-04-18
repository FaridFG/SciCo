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
    public class MessageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IActionResult> SendMessage(string receiverId, string messageContent)
        {
            Message message = new Message
            {
                Sender = await _userManager.FindByNameAsync(User.Identity.Name),
                Receiver = await _db.Users.FindAsync(receiverId),
                Content = messageContent
            };

            if (message == null)
            {
                return NotFound();
            }

            await _db.Messages.AddAsync(message);
            await _db.SaveChangesAsync();
            return RedirectToAction("Timeline", "Account", new { id = receiverId });
        }

        public IActionResult ShowMessages()
        {
            return View();
        }

        public IActionResult ReplyToMessage()
        {
            return View();
        }
    }
}