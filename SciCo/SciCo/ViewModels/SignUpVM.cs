using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SciCo.ViewModels
{
    public class SignUpVM
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(255)]
        public string Username { get; set; }

        [Required, StringLength(255), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, StringLength(255), MinLength(7), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "You must agree with Terms and Conditions of our Company")]
        public bool Terms { get; set; }
    }
}
