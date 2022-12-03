using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public class SingleProduct : Product
    {
        private string category, subCategory, unit;
        private double price;
        private byte[]? image;
        private bool inStock;

        public string Category { get { return category; } private set { category = value; } }
        public string SubCategory { get { return subCategory; } private set { subCategory = value; } }
        public string Unit { get { return unit; } private set { unit = value; } }
        public double Price { get { return price; } private set { price = value; } }
        public byte[]? Image { get { return image; } private set { image = value; } }
        public bool InStock { get { return inStock; } private set { inStock = value; } }


        public SingleProduct(string name, string category, string subCatgeory, string unit, double price, byte[]? image, bool inStock, DateTime? lastModified) : base(name, lastModified) 
        {
            Category = category;
            SubCategory = subCatgeory;
            Unit = unit;
            Price = price;
            InStock = inStock;
            Image = image;
        }
        public SingleProduct(int id, string name, string category, string subCatgeory, string unit, double price, byte[]? image, bool inStock, DateTime? lastModified) : base(id, name, lastModified)
        {
            Category = category;
            SubCategory = subCatgeory;
            Unit = unit;
            Price = price;
            InStock = inStock;
            Image = image;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool GetInStock()
        {
            return InStock;
        }
    }
}
