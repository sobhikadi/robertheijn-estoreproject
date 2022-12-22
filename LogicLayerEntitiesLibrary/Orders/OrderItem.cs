using LogicLayerEntitiesLibrary.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int? OrderId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double PricePerItem { get; private set; }
        public double Total { 
            get 
            {
                return PricePerItem * Quantity;
            }
            private set { } }

        public OrderItem(int? orderId, Product product, int quantity, double price) 
        {
            OrderId = orderId;
            Product = product;
            Quantity = quantity;
            PricePerItem = price;
        }

        public OrderItem(int id, int? orderId, Product product, int quantity, double price)
        {
            Id = id;
            OrderId = orderId;
            Product = product;
            Quantity = quantity;
            PricePerItem = price;
        }

        public void ChangeQuantity(int amount) 
        {
            Quantity = amount;
        }
    }

    
}
