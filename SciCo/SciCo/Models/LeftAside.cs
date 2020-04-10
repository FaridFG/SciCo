using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.Models
{
    public class LeftAside
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(255)]
        public string IconClass { get; set; }

        [Required, StringLength(100)]
        public string ColorClass { get; set; }
    }
}
