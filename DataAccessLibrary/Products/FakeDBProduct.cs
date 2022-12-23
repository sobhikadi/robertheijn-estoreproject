using LogicLayerEntitiesLibrary.Products;
using LogicLayerEntitiesLibrary.Products.DiscountS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Products
{
    public class FakeDBProduct : IDBMediatorProducts
    {
        public int AddAdvertisement(Product product, Discount discount)
        {
            return 1;
        }

        public bool DeleteProduct(Product product)
        {
            return true;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            return products;
        }

        public List<Suffix> GetAllSuffixes()
        {
            List<Suffix> suffixes = new List<Suffix>();

            return suffixes;
        }

        public int InsertProduct(Product product)
        {
            return 1;
        }

        public int InsertSuffix(Suffix suffix)
        {
            return 1;
        }

        public List<Product> SearchProduct(string term, ProductSearchType type)
        {
            List<Product> products = new List<Product>();

            return products;
        }

        public bool UpdateProduct(Product newProduct, Product currentProduct)
        {
            return true;
        }
    }
}
