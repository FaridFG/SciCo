using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewModels
{
    public class MessageVM
    {
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<AppUser> Senders { get; set; }
        public AppUser Receiver { get; set; }
    }
}
