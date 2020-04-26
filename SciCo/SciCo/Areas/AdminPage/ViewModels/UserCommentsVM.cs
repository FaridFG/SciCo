using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Areas.AdminPage.ViewModels
{
    public class UserCommentsVM
    {
        public AppUser MainUser { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<AppUser> Users { get; set; }
    }
}
