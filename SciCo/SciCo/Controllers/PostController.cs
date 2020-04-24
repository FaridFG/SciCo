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
    public class PostController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public PostController(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IActionResult> CreatePost(string newPost)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (newPost == null || newPost == "")
            {
                return NotFound();
            }

            Post post = new Post
            {
                Poster = user,
                Content = newPost,
                Time = DateTime.Now
            };

            if (post == null)
            {
                return NotFound();
            }

            await _db.Posts.AddAsync(post);
            await _db.SaveChangesAsync();

            return RedirectToAction("Newsfeed", "Account");
        }

        public async Task<IActionResult> WriteComment(string newComment, int postId)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (newComment == null || newComment == "")
            {
                return NotFound();
            }

            Comment comment = new Comment
            {
                Commenter = user,
                Content = newComment,
                Time = DateTime.Now,
                Post = await _db.Posts.FindAsync(postId)
            };

            if (comment == null)
            {
                return NotFound();
            }

            await _db.Comments.AddAsync(comment);
            await _db.SaveChangesAsync();

            return RedirectToAction("Newsfeed", "Account");
        }

        public async Task<IActionResult> Like(int postId)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (_db.Likes.Any(l => l.Post.Id == postId && l.Liker == user))
            {
                return NotFound();
            }

            Like like = new Like
            {
                Liker = user,
                Post = await _db.Posts.FindAsync(postId)
            };

            if (like == null)
            {
                return NotFound();
            }

            await _db.Likes.AddAsync(like);
            await _db.SaveChangesAsync();

            return RedirectToAction("Newsfeed", "Account");
        }

        public async Task<IActionResult> Dislike(int postId)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (_db.Dislikes.Any(d => d.Post.Id == postId && d.Disliker == user))
            {
                return NotFound();
            }

            Dislike dislike = new Dislike
            {
                Disliker = user,
                Post = await _db.Posts.FindAsync(postId)
            };

            if (dislike == null)
            {
                return NotFound();
            }

            await _db.Dislikes.AddAsync(dislike);
            await _db.SaveChangesAsync();

            return RedirectToAction("Newsfeed", "Account");
        }
    }
}