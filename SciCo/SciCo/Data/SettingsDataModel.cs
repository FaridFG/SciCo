using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo
{
    public class SettingsDataModel
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2048)]
        public string Value { get; set; }
    }
}
