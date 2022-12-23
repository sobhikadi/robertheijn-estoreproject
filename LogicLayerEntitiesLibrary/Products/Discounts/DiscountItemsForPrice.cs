﻿using LogicLayerEntitiesLibrary.Products.DiscountS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products.Discounts
{
    public class DiscountItemsForPrice : IDiscount
    {
        public double? CalculateDiscount(int? amountProducts, double? productPrice, double? flatDiscount)
        {
            return productPrice * amountProducts;
        }
    }
}
