using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class Dislike
    {
        public int Id { get; set; }
        [Required]
        public AppUser Disliker { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public Post Post { get; set; }
    }
}
