using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SavingandLoanProject.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Please enter your email")]
        [EmailAddress]
        public string  EmailAddress { get; set; }
        [Required(ErrorMessage ="Please enter your Password")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required(ErrorMessage ="Please confirm your password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string  ConfirmPassword { get; set; }
    }
}
