using SciCo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewModels
{
    public class SearchVM
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
    }
}
