using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayerEntitiesLibrary.Users;
using LogicLayerHandlersLibrary;
using DataAccessLibrary.Employees;
using LogicLayerEntitiesLibrary.Products;
using System.IO;
using LogicLayerEntitiesLibrary.Orders;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace Website.Pages
{
    public class CartModel : PageModel
    {

        public List<OrderItem> CartItems { get; set; } = new List<OrderItem>();

        public double SubTotal { get; set; }

        public IActionResult OnGet()
        {
            string position = "";
            string userName = "";

            if (!Request.Cookies.ContainsKey("robert_heijn_remember_me_cookie") && !HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToPage("LogIn");
            }

            if (Request.Cookies.ContainsKey("robert_heijn_remember_me_cookie") && !HttpContext.User.Identity.IsAuthenticated)
            {
                string[] coockieValue = Request.Cookies["robert_heijn_remember_me_cookie"].Split("-");

                position = coockieValue[1];
                userName = coockieValue[0];
            }
            else if (HttpContext.User.Identity.IsAuthenticated)
            {
                userName = HttpContext.User.Identity.Name;
                position = HttpContext.User.FindFirst("position").Value;
            }
            UserHandler userHandler = new UserHandler(new DBUser());
            
            User customer = userHandler.Users.FirstOrDefault(i => i.Email == userName);

            CartItems = HttpContext.Session.GetObject<List<OrderItem>>(userName) ?? new List<OrderItem>();

            CartItems.ForEach(i => SubTotal += i.Total);

            return Page();

        }

        public void OnPostMinus() 
        {

        }
    }
}
