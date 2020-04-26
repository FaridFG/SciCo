using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Areas.AdminPage.ViewModels
{
    public class ShowMessageVM
    {
        public AppUser MainUser { get; set; }
        public IEnumerable<AppUser> Sender { get; set; }
        public IEnumerable<Message> Messages { get; set; }
    }
}
