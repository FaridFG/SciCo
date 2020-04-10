using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class AppUser : IdentityUser
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Surname { get; set; }
        public string Hometown { get; set; }
        public string CurrentCity { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string ProfilePhoto { get; set; }
        public string CoverPhoto { get; set; }
    }
}
