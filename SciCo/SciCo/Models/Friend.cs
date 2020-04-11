using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class Friend
    {
        public int Id { get; set; }
        [Required]
        public AppUser User1 { get; set; }
        [Required]
        public AppUser User2 { get; set; }
    }
}
