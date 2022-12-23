using DataAccessLibrary.Products;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerEntitiesLibrary.Products.DiscountS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerHandlersLibrary
{
    public class ProductHandler
    {
        private IDBMediatorProducts dbHandlerProduct;
        private List<Product> products;

        public ProductHandler(IDBMediatorProducts dBMediatorProduct)
        {
            dbHandlerProduct = dBMediatorProduct;
            products = new List<Product>();
            UpdateListOfProducts();
        }

        public IList<Product> Products { get { return products.AsReadOnly(); } }

        public void AddProduct(Product product)
        {
            int id = dbHandlerProduct.InsertProduct(product);
            if (id == 0) throw new ArgumentException("Product has not been added successfully");
            product.Id = id;
            products.Add(product);
        }

        public void UpdateProduct(Product newProduct, Product currentProduct)
        {
            bool success = dbHandlerProduct.UpdateProduct(newProduct, currentProduct);
            if (!success) throw new ArgumentException("Product has not been updated successfully");

            foreach (Product p in products) 
            {
                if(p.Id == currentProduct.Id) p.ChangeInformation(newProduct);
            }
        }

        public void DeleteProduct(Product product)
        {
            bool deleted = dbHandlerProduct.DeleteProduct(product);
            if (!deleted) throw new ArgumentException("Product has not been deleted successfully");
            products.Remove(product);
        }

        public void AddAdvertisement(Product product, Discount discount) 
        {
            int id = dbHandlerProduct.AddAdvertisement(product, discount);
            if (id == 0) throw new ArgumentException("Discount has not been added successfully");
            Product p =  products.FirstOrDefault(i => i.Id == product.Id);
            p.AddAdvertisement(discount);
        }

        public List<Product> SearchProduct(string term, ProductSearchType type)
        {
            return dbHandlerProduct.SearchProduct(term, type);
        }

        private void UpdateListOfProducts()
        {
            products.Clear();
            products.AddRange(dbHandlerProduct.GetAllProducts());
        }
    }
}
