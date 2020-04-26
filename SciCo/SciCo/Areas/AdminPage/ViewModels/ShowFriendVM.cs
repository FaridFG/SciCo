using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Areas.AdminPage.ViewModels
{
    public class ShowFriendVM
    {
        public AppUser MainUser { get; set; }
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<Friend> Friends { get; set; }
    }
}
