using LogicLayerEntitiesLibrary.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Products
{
    public interface IDBMediatorProducts
    {
        public int InsertProduct(Product product);

        public bool DeleteProduct(Product product);
        public List<Product> GetAllProducts();
        public List<Product> SearchProduct(string term, ProductSearchType type);
    }
}
