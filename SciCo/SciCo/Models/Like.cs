using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class Like
    {
        public int Id { get; set; }
        [Required]
        public AppUser Liker { get; set; }
        [Required]
        public Post Post { get; set; }
    }
}
