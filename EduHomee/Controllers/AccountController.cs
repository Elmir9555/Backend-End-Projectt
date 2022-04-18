using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EduHomee.Migrations;
using EduHomee.Models;
using EduHomee.ViewModels.Account;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
//using SignInResult = Microsoft.AspNetCore.Mvc.SignInResult;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EduHomee.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<EduHomee.Models.AppUser> _userManager;
        private readonly SignInManager<EduHomee.Models.AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;


        public AccountController(UserManager<EduHomee.Models.AppUser> userManager, SignInManager<EduHomee.Models.AppUser> signInManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;


        }
        


        #region Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            EduHomee.Models.AppUser newUser = new EduHomee.Models.AppUser()
            {
                FullName = registerVM.FullName,
                UserName = registerVM.Username,
                Email = registerVM.Email
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
                return View(registerVM);
            }


            if (string.IsNullOrWhiteSpace(registerVM.Email))
            {
                return RedirectToAction("Index", "Error");
            }
            EduHomee.Models.AppUser appUser = await _userManager.FindByEmailAsync(registerVM.Email);

            if (appUser == null)
                return RedirectToAction("Index", "Error");

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("EduHome", "elmirustayev9@gmail.com"));

            message.To.Add(new MailboxAddress(appUser.FullName, appUser.Email));
            message.Subject = "Confirm Email";

            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Confirm.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }

            

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            var url = Url.Action(nameof(VerifyEmail), "Account", new { userId = newUser.Id, token = code }, Request.Scheme, Request.Host.ToString());


            emailbody = emailbody.Replace("{{fullname}}", $"{appUser.FullName}").Replace("{{code}}", $"{url}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("elmirustayev9@gmail.com", "Elmir2002");
            smtp.Send(message);
            smtp.Disconnect(true);


            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> VerifyEmail(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            EduHomee.Models.AppUser user = await _userManager.FindByIdAsync(userId);

            if (user is null) return BadRequest();


            await _userManager.ConfirmEmailAsync(user, token);

            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            EduHomee.Models.AppUser user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
            if (user is null)
            {
                user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);

            }

            if (user is null)
            {
                ModelState.AddModelError("", "Email or Password is Wrong");
                return View(loginVM);
            }



            SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

            if (!signInResult.Succeeded)
            {
                if (signInResult.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Please Confirm Your Accaunt");
                    return View(loginVM);
                }
                ModelState.AddModelError("", "Email or Password is Wrong");
                return View(loginVM);
            }

            return RedirectToAction("Index", "Home");
        }
        #endregion
        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }
        #endregion
    }
}
