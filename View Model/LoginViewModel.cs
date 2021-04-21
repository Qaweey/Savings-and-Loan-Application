using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavingandLoanProject.ViewModels
{
    public class LoginViewModel
    {
        public string  Email { get; set; }
        public string  password { get; set; }
        public bool Rememberme { get; set; }
    }
}
