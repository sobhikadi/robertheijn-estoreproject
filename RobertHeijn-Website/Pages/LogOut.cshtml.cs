using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {
			if (Request.Cookies.ContainsKey("robert_heijn_remember_me_cookie"))
			{
				Response.Cookies.Delete("robert_heijn_remember_me_cookie");
			}
			HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return new RedirectToPageResult("/index");
		}
    }
}
