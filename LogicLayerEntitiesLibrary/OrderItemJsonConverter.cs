using LogicLayerEntitiesLibrary.Orders;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicLayerEntitiesLibrary
{
    public class OrderItemJsonConverter : Newtonsoft.Json.JsonConverter
    {
        public override List<OrderItem> ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            // Load the JSON for the Result into a JObject
            JArray ja = JArray.Load(reader);

            
            List<OrderItem> items = new List<OrderItem>();
            // Read the properties which will be used as constructor parameters
            foreach (JObject jo in ja) 
            {
                int? orderId = (int?)jo["OrderId"];
                int productId = (int)jo["ProductId"];
                int quantity = (int)jo["Quantity"];
                double price = (double)jo["PricePerItem"];

                items.Add(new OrderItem(orderId, productId, quantity, price));
            }
            
            


            // Construct the Result object using the non-default constructor
            

            // (If anything else needs to be populated on the result object, do that here)

            // Return the result
            return items;
        }


        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<OrderItem>));
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
