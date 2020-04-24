using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class Post
    {
        public int Id { get; set; }
        public AppUser Poster { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public DateTime Time { get; set; }
    }
}
