using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SciCo.Data;
using SciCo.Models;
using SciCo.ViewModels;

namespace SciCo.Controllers
{
    [Authorize]
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
                Content = messageContent,
                Time = DateTime.Now
            };

            if (message == null)
            {
                return NotFound();
            }

            await _db.Messages.AddAsync(message);
            await _db.SaveChangesAsync();
            return RedirectToAction("Timeline", "Account", new { id = receiverId });
        }

        public async Task<IActionResult> ShowMessages()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            MessageVM model = new MessageVM
            {
                Messages = _db.Messages.Where(m => m.Receiver == user),
                Senders = _db.Messages.Where(m => m.Receiver == user).Select(m => m.Sender),
                Receiver = user
            };
            return View(model);
        }

        public async Task<IActionResult> ViewAllMessages()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            MessageVM model = new MessageVM
            {
                Messages = _db.Messages.Where(m => m.Receiver == user),
                Senders = _db.Messages.Where(m => m.Receiver == user).Select(m => m.Sender),
                Receiver = user
            };
            return View(model);
        }

        public IActionResult ReplyToMessage()
        {
            return View();
        }
    }
}