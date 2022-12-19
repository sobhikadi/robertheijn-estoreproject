using DataAccessLibrary.Products;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerHandlersLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private SuffixesHandler suffixesHandler;

        public List<Suffix> categories { get; set; } = new List<Suffix>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            suffixesHandler = new(new DBProduct());
            categories.Clear();

            foreach (Suffix suffix in suffixesHandler.Suffixes) 
            {
                if (suffix.SuffixType == SuffixType.category) 
                {
                    categories.Add(suffix);
                }
            }

        }
    }
}