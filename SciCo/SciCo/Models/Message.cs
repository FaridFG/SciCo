using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public AppUser Sender { get; set; }
        [Required]
        public AppUser Receiver { get; set; }
        [Required, StringLength(500)]
        public string Content { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public bool HasSeen { get; set; }
    }
}
