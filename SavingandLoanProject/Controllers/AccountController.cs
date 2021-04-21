using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SavingandLoanProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavingandLoanProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        // GET: AccountController
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public  async Task< IActionResult> RegisterNewUser(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var identityUser = new IdentityUser
                {
                    Email = registerViewModel.EmailAddress,
                    UserName = registerViewModel.EmailAddress
                };
                var createdUser= await userManager.CreateAsync(identityUser);
                if (createdUser.Succeeded)
                {
                    await signInManager.SignInAsync(identityUser, false);
                }

                return RedirectToAction("Homepage", "Home");

            }
            ModelState.AddModelError("", "An error occured");
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public  async Task <IActionResult> Login(LoginViewModel model)
        {
            var passworduseridentity = new IdentityUser
            {
                Email = model.Email,
                UserName = model.Email

            };

            if (ModelState.IsValid)
            {
               var w= await signInManager.PasswordSignInAsync(passworduseridentity, model.password, model.Rememberme, true);

                if (w.Succeeded)
                {
                    return RedirectToAction("index", "Home");
                }

            }
            ModelState.AddModelError("", "Error Occured");
            return View();
            
        }

    }
}
