using DataAccessLibrary.Products;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerHandlersLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class ProductsModel : PageModel
    {
        private ProductHandler productHandler = new ProductHandler(new DBProduct());
        
        private SuffixesHandler suffixesHandler = new(new DBProduct());


        public List<Product> Products { get; set; } = new List<Product>();


        public List<Suffix> categories { get; set; } = new List<Suffix>();

        public void OnGet(string category)
        {
            categories.Clear();

            foreach (Suffix suffix in suffixesHandler.Suffixes)
            {
                if (suffix.SuffixType == SuffixType.category)
                {
                    categories.Add(suffix);
                }
            }

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
}
