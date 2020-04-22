using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewModels
{
    public class FriendVM
    {
        public AppUser MainUser { get; set; }
        public IEnumerable<AppUser> FriendUsers { get; set; }
        public IEnumerable<Friend> Friends { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
