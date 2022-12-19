using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
	[Authorize]
    public class UserPageModel : PageModel
    {
        public void OnGet()
        {
			
		}
    }
}
