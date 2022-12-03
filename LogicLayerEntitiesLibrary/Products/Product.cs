using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public abstract class Product
    {
        private string name;
        DateTime? lastModified;

        public int Id { get; set; }
        public string Name { get { return name; } private set { name = value; } }
        public DateTime? LastModified { get { return lastModified; } private set { lastModified = value; } }

        public Product(string name, DateTime? lastModified) 
        {
            Name = name;
            LastModified = lastModified;
        }

        public Product(int id, string name, DateTime? lastModified) 
        {
            Id = id;
            Name = name;
            LastModified = lastModified;
        }

        public abstract bool GetInStock();
        public abstract double GetPrice();




    }
}
