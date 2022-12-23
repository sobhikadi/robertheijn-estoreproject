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
            throw new NotImplementedException();
        }

        public bool DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<Suffix> GetAllSuffixes()
        {
            throw new NotImplementedException();
        }

        public int InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public int InsertSuffix(Suffix suffix)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProduct(string term, ProductSearchType type)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product newProduct, Product currentProduct)
        {
            throw new NotImplementedException();
        }
    }
}
