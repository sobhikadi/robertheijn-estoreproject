using DataAccessLibrary.Products;
using LogicLayerEntitiesLibrary.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerHandlersLibrary
{
    public class ProductHandler
    {
        private IDBMediatorProducts dbHandlerProducts;
        private List<Product> products;

        public ProductHandler(IDBMediatorProducts dBMediatorProduct)
        {
            dbHandlerProducts = dBMediatorProduct;
            products = new List<Product>();
            UpdateListOfProducts();
        }

        public IList<Product> Products { get { return products.AsReadOnly(); } }

        public void AddProduct(Product product)
        {
            int id = dbHandlerProducts.InsertProduct(product);
            if (id == 0) throw new Exception("Product has not been added successfully");
            product.Id = id;
            products.Add(product);
        }

        public void UpdateProduct(Product newProduct, Product currentProduct)
        {
            bool success = dbHandlerProducts.UpdateProduct(newProduct, currentProduct);
            if (!success) throw new ArgumentException("Product has not been updated successfully");

            foreach (Product p in products) 
            {
                if(p.Id == currentProduct.Id) p.ChangeInformation(newProduct);
            }
        }

        public void DeleteProduct(Product product)
        {
            bool deleted = dbHandlerProducts.DeleteProduct(product);
            if (!deleted) throw new ArgumentException("Product has not been deleted successfully");
            products.Remove(product);
        }

        public List<Product> SearchProduct(string term, ProductSearchType type)
        {
            return dbHandlerProducts.SearchProduct(term, type);
        }

        private void UpdateListOfProducts()
        {
            products.Clear();
            products.AddRange(dbHandlerProducts.GetAllProducts());
        }
    }
}
