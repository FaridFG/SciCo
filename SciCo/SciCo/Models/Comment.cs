using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public AppUser Commenter { get; set; }
        public Post Post { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
    }
}
