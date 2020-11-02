﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace MotaskraningWeb2.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<IdentityUser> signInManager, 
            ILogger<LoginModel> logger,
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public class LoginHlutur
        {
            [Required]
            [EmailAddress]
            public string username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string password { get; set; }
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {

                LoginHlutur hlutur = new LoginHlutur();
                hlutur.username = Input.Email;
                hlutur.password = Input.Password;




                var client = new HttpClient();
                var result = await client.PostAsync("https://api.fri.is/user/login", new StringContent(JsonConvert.SerializeObject(hlutur), Encoding.UTF8, "application/json"));
                var contents = await result.Content.ReadAsStringAsync();

                // Ef login virkaði þá setja kökuna og riderecta á síðuna, annars rediracta á login aftur eða villu síðu með skilaboðunum að 
                // þetta hafi ekki virkað. Skoða villuskilaboðin frá Bergi og gá hvort það sé eithvað sem ég geti étið upp úr þeim. 
                // Kannski éta það upp hvort það sé notendanafnið eða lykilorðið.

                // If it worked to log in then create the login cookie.
                if (result.IsSuccessStatusCode)
                {
                    //public void Set(string key, string value, int? expireTime)
                    //{
                        // Set cookie options
                        CookieOptions option = new CookieOptions();
                        option.Expires = DateTime.Now.AddMinutes(30);

                        // Append the cookie to cookies
                        Response.Cookies.Append("Key", "FRI-MOTASKRANING", option);
                    //}

                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, contents);
                    return Page();
                }

                // return LocalRedirect(returnUrl);

                /*
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }*/
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
