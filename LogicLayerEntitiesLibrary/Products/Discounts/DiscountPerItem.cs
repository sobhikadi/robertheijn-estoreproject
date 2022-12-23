using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products.DiscountS
{
    public class DiscountPerItem : IDiscount
    {
        public double? CalculateDiscount(int? amountProducts, double? productPrice, double? flatDiscount)
        {
            return flatDiscount;
        }
    }
}
