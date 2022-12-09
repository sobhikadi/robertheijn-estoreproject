using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public class Product
    {
        private string name, category, subCategory, unit;
        DateTime? lastModified;
        private double price;
        private byte[]? image;
        private bool inStock;

        public int Id { get; set; }
        public string Name { get { return name; } private set { name = value; } }
        public DateTime? LastModified { get { return lastModified; } private set { lastModified = value; } }
        public string Category { get { return category; } private set { category = value; } }
        public string SubCategory { get { return subCategory; } private set { subCategory = value; } }
        public string Unit { get { return unit; } private set { unit = value; } }
        public double Price { get { return price; } private set { price = value; } }
        public byte[]? Image { get { return image; } private set { image = value; } }
        public bool InStock { get { return inStock; } private set { inStock = value; } }
        public List<Bonus> Bonus { get; private set; }

        public Product(string name, string category, string subCatgeory, string unit, double price, byte[]? image, bool inStock, DateTime? lastModified) 
        {
            Name = name;
            LastModified = lastModified;
            Category = category;
            SubCategory = subCatgeory;
            Unit = unit;
            Price = price;
            InStock = inStock;
            Image = image;
            Bonus = new List<Bonus>();
        }

        public Product(int id, string name, string category, string subCatgeory, string unit, double price, byte[]? image, bool inStock, DateTime? lastModified) 
        {
            Id = id;
            Name = name;
            LastModified = lastModified;
            Category = category;
            SubCategory = subCatgeory;
            Unit = unit;
            Price = price;
            InStock = inStock;
            Image = image;
        }
    }
}
