﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Orders
{
    public class Order
    {
        public int Id { get; private set; }
        public DateTime OrderDate { get; private set; }
        public EnumsOrder.DeliveryOption DeliveryOption { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public EnumsOrder.OrderStatus Status { get; private set; }
        public List<OrderItem> OrderItems { get; private set; }
        public double Total { get; private set; }

    }
}
