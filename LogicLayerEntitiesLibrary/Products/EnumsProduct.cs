using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public enum ProductSearchType
    {
        id,
        name,
        category,
        sub_category
    }

    public enum DiscountRules
    {
        PerUnits,
        ItemFree,
        HalfPrice,
        UnitsForPrice
    }

    public enum SuffixType
    {
        category,
        sub_category,
        unit
    }
}
