using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace plz.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Required")]
        [DisplayName("First Name : ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Last Name : ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Email : ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
