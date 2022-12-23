using LogicLayerEntitiesLibrary.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testsuite
{
    [TestClass]
    public class ProductTest
    {

        [TestMethod]
        public void ConstructorTest() 
        {
            Suffix category = new("category", SuffixType.category);
            Suffix subCategory = new("SubCategory", SuffixType.sub_category);
            Suffix unit = new("Unit", SuffixType.unit);

            Product p = new Product("Cabbage", category, subCategory, unit, 2.99, null, true, null);

            Assert.AreEqual("Cabbage", p.Name);
            Assert.AreEqual("SubCategory", p.SubCategory.Name);
            Assert.AreEqual(null, p.Image);
        }

        [TestMethod]
        public void CalculateDiscountTest() 
        {
            Suffix category = new("category", SuffixType.category);
            Suffix subCategory = new("SubCategory", SuffixType.sub_category);
            Suffix unit = new("Unit", SuffixType.unit);

            Product p = new Product("Cabbage", category, subCategory, unit, 2.99, null, true, null);

            double? discountValue = p.CalculateDiscount(DiscountRules.ItemFree, 2, p.Price, null);

            Assert.AreEqual(discountValue, 2.99);

        }
    }
}
