using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using LogicLayerEntitiesLibrary.Users;
using LogicLayerHandlersLibrary;
using DataAccessLibrary.Employees;

namespace Website.Pages
{
    public class LogInModel : PageModel
    {

        [BindProperty]
        [Required(ErrorMessage = "Field Must be entered")]
        public string UserName { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Field Must be entered")]
        public string Password { get; set; }
        [BindProperty]
        public bool RememberMe { get; set; }

        public IActionResult OnGet(string successMessage)
        {
            ViewData["successMessage"] = successMessage;

            string position = "";

            if (Request.Cookies.ContainsKey("robert_heijn_remember_me_cookie") && !HttpContext.User.Identity.IsAuthenticated)
            {
                string[] coockieValue = Request.Cookies["robert_heijn_remember_me_cookie"].Split("-");

                position = coockieValue[1];
                UserName = coockieValue[0];

                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, UserName));
                claims.Add(new Claim("position", position));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = false,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
                };
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
            }
            else if (HttpContext.User.Identity.IsAuthenticated)
            {
                UserName = HttpContext.User.Identity.Name;
                position = HttpContext.User.FindFirst("position").Value;
            }

            
            if (position.Trim() == "Customer") return new RedirectToPageResult("UserPage");
            
            return Page();
        }

        public IActionResult OnPost()
        {
            UserHandler handler = new UserHandler(new DBUser());
            User customer = handler.ValidateUser(UserName, Password);

            if (customer == null)
            {
                ViewData["LoginMessage"] = "Email or Passwrod is incorrect";
                return Page();
            }
            //set a coockie to keep logged in 
            if (RememberMe)
            {
                // set a coockie with a username
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(30);
                cookieOptions.Secure = true;
                cookieOptions.HttpOnly = true;
                Response.Cookies.Append("robert_heijn_remember_me_cookie", $"{UserName}- Customer", cookieOptions);
            }
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, UserName));
            claims.Add(new Claim("position", "Customer"));

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                IsPersistent = false,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
            };
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
            if (User != null)
            {
                return new RedirectToPageResult("UserPage");
            }
            return new RedirectToPageResult("LogIn");
        }
    }
}
