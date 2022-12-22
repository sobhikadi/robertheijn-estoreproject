using DataAccessLibrary.Products;
using LogicLayerEntitiesLibrary.Orders;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerHandlersLibrary;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Nancy.Json;
using LogicLayerEntitiesLibrary;

namespace Website.Pages
{
    public class ProductsModel : PageModel
    {
        private ProductHandler productHandler = new ProductHandler(new DBProduct());

        private SuffixesHandler suffixesHandler = new(new DBProduct());

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Suffix> categories { get; set; } = new List<Suffix>();

        private List<OrderItem> orderItems = new List<OrderItem>();

        [BindProperty]
        public int Quantity { get; set; }

        [BindProperty]
        public int ProductId { get; set; }


        public void OnGet(string category, string failMessages)
        {
            ViewData["failMessages"] = failMessages;

            AddCategories();
            AddProducts(category);
        }

        public IActionResult OnPost()
        {
            string path = "Products";

            if (!Request.Cookies.ContainsKey("robert_heijn_remember_me_cookie") && !HttpContext.User.Identity.IsAuthenticated)
            {
                return new RedirectToPageResult(path, new { failMessages = "NotLoggedIn" });
            }
            else
            {
                string position = "";
                string userName = "";

                if (!Request.Cookies.ContainsKey("robert_heijn_remember_me_cookie") && !HttpContext.User.Identity.IsAuthenticated)
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
                Product product = productHandler.Products.FirstOrDefault(p => p.Id == ProductId);

             

                List<OrderItem> cart = HttpContext.Session.GetObject<List<OrderItem>>(userName) ?? new List<OrderItem>();
                OrderItem cartItem = cart.FirstOrDefault(i => i.ProductId == product.Id);

                if (!product.InStock) return new RedirectToPageResult(path, new { failMessages = $"The item {product.Name} went out of stock, therefore is no longer possible to order" });
                if (cartItem != null)
                {
                    return new RedirectToPageResult(path, new { failMessages = $"The Item {product.Name} is already in cart" });
                }
                
                cart.Add(new OrderItem(null, product.Id, Quantity, product.Price));
                HttpContext.Session.SetObject(userName, cart);


                //return Redirect(Request.Headers["Referer"].ToString());
                return new RedirectToPageResult(path, new { failMessages = $"The item {product.Name} has successfully been added to the cart" });
            }
        }



        private void AddCategories() 
        {
            categories.Clear();

            foreach (Suffix suffix in suffixesHandler.Suffixes)
            {
                if (suffix.SuffixType == SuffixType.category)
                {
                    categories.Add(suffix);
                }
            }
        }

        private void AddProducts(string category) 
        {
            Products.Clear();

            foreach (Product product in productHandler.Products)
            {
               
                    if (product.Category.Name == category)
                    {
                        Products.Add(product);
                    }
                    else if (string.IsNullOrEmpty(category)) Products.Add(product);
                
            }
        }
    }

    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Converters.Add(new OrderItemJsonConverter());

            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value, settings);
        }
    }
}
