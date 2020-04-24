using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewModels
{
    public class PostVM
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Like> Likes { get; set; }
        public IEnumerable<Dislike> Dislikes { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<AppUser> Users { get; set; }
    }
}
