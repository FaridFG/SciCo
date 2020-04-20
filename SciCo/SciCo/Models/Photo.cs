using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        public AppUser user { get; set; }
        [Required, StringLength(255)]
        public string Link { get; set; }
        [NotMapped, Required]
        public IFormFile Image { get; set; }
        public bool isProfilePhoto { get; set; }
        public bool isCoverPhoto { get; set; }
    }
}
