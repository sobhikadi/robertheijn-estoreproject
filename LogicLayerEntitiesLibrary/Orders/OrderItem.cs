using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Orders
{
    public class OrderItem
    {
        public int ProductId { get; private set; }
        public int OrderId { get; private set; }
        public int Quantity { get; private set; }
        public double PricePerItem { get; private set; }
        public double Total { get; private set; }
    }
}
