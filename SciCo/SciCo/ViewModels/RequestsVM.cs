using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewModels
{
    public class RequestsVM
    {
        public IEnumerable<FriendRequest> Requests { get; set; }
        public IEnumerable<AppUser> RequestorUsers { get; set; }
        public AppUser ReceiverUser { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
