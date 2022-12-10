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
            if (CheckProductExist(product)) throw new Exception($"Product with the name {product.Name} already exists");
            int id = dbHandlerProducts.InsertProduct(product);
            if (id == 0) throw new Exception("Product has not been added successfully");
            product.Id = id;
            products.Add(product);
        }

        public void UpdateProduct(Product newProduct, Product currentProduct)
        {
            //bool success = dbHandlerProducts.UpdateProduct(newProduct, currentProduct);

            //if (!success) throw new ArgumentException("");

            //if (!products.Contains(currentProduct)) throw new ArgumentException("");

            //currentProduct.ChangeInformation(newProduct);

        }

        public void DeleteProduct(Product product)
        {
            //if (CheckProductExist(product) == false) throw new Exception($"Product with the name {product.Name} does not exist");
            //bool deleted = dbHandlerProducts.DeleteProduct(product);
            //if (!deleted) throw new ArgumentException("Product has not been deleted successfully");
            //products.Remove(product);
        }

        public List<Product> SearchProduct(string term, ProductSearchType type)
        {
            List<Product> sproducts = new List<Product>();
            //return dbHandlerProducts.SearchProduct(term, type);
            return sproducts;
        }

        private bool CheckProductExist(Product product)
        {
            foreach (Product prod in products)
            {
                if (prod.Name == product.Name) return true;
            }
            return false;
        }

        private void UpdateListOfProducts()
        {
            //products.Clear();
            //foreach (Product product in dbHandlerProducts.GetAllProducts())
            //{
            //    products.Add(product);
            //}  
        }
    }
}
