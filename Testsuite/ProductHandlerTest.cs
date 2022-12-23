using DataAccessLibrary.Employees;
using DataAccessLibrary.Products;
using LogicLayerEntitiesLibrary.Exceptions;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerHandlersLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testsuite
{
    [TestClass]
    public class ProductHandlerTest
    {
        private ProductHandler productHandler = new ProductHandler(new FakeDBProduct());

        [TestMethod]
        public void AddProductSuccessTest()
        {
            Suffix category = new("category", SuffixType.category);
            Suffix subCategory = new("SubCategory", SuffixType.sub_category);
            Suffix unit = new("Unit", SuffixType.unit);


            Product p = new Product("cabbage", category, subCategory, unit, 2.99, null, true, null);

            productHandler.AddProduct(p);

            bool isAdded = CheckIfProductExist(p);

            Assert.IsTrue(isAdded);
        }

        [TestMethod]
        [ExpectedException(typeof(NullValueException))]
        public void AddProductFailTest()
        {
            try
            {
                Suffix category = new("category", SuffixType.category);
                Suffix subCategory = new("SubCategory", SuffixType.sub_category);
                Suffix unit = new("Unit", SuffixType.unit);


                Product p = new Product("", category, subCategory, unit, 2.99, null, true, null);

                productHandler.AddProduct(p);

            }
            catch (NullValueException ex) 
            {
                Assert.AreEqual("The field name cannot be empty", ex.Message);
                throw;
            }

        }

        private bool CheckIfProductExist(Product product) 
        {
            foreach (Product p in productHandler.Products) 
            {
                if(product.Name == product.Name) return true;
            }
            return false;
        }

    }
}
