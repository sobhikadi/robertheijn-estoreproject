using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Orders
{
    public enum OrderStatus
    {
        processing,
        preparing,
        shipping,
        on_the_way,
        delivered
    }

    public enum DeliveryOption
    {
        pick_up,
        home_delivery
    }
}
