using LogicLayerEntitiesLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string Name { get { return name; } 
            private set 
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field name cannot be empty");
                if (value.Length < 3 || value.Length > 255) throw new OutOfrangeException("Name must have at least 3 charachters and maximum of 255 charachters");
                name = value;
            } 
        }
        public string Category { get { return category; } 
            private set 
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field category cannot be empty");
                if (value.Length < 3 || value.Length > 255) throw new OutOfrangeException("Category must have at least 3 charachters and maximum of 255 charachters");
                category = value; 
            } 
        }
        public string SubCategory { get { return subCategory; } 
            private set 
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field subcategory cannot be empty");
                if (value.Length < 3 || value.Length > 255) throw new OutOfrangeException("Subcategory must have at least 3 charachters and maximum of 255 charachters");
                subCategory = value; 
            } 
        }
        public string Unit { get { return unit; } 
            private set 
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field unit cannot be empty");
                if (value.Length < 2 || value.Length > 100) throw new OutOfrangeException("Unit must have at least 2 charachters and maximum of 100 charachters");
                unit = value; 
            } 
        }
        public double Price { get { return price; } 
            private set 
            {
                if (value < 0) throw new OutOfrangeException("Price cannot be less than 0");
                price = value;
            } 
        }
        public byte[]? Image { get { return image; } private set { image = value; } }
        public DateTime? LastModified { get { return lastModified; } private set { lastModified = value; } }
        public bool InStock { get { return inStock; } private set { inStock = value; } }
        public List<Discount> Bonus { get; private set; }

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
            Bonus = new List<Discount>();
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

        public void ChangeInformation(Product newProduct)
        { 
            Name = newProduct.name;
            Category = newProduct.Category;
            SubCategory = newProduct.SubCategory;
            Unit = newProduct.Unit;
            Price = newProduct.Price;
            InStock = newProduct.InStock;
            Image = newProduct.Image;
            LastModified = newProduct.LastModified;
        }
    }
}
