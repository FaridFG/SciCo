using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class FriendRequest
    {
        public int Id { get; set; }
        [Required]
        public AppUser RequestorUser { get; set; }
        [Required]
        public AppUser ReceiverUser { get; set; }
    }
}
