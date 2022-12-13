using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public abstract class Suffix 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Suffix(string name)
        {
            Name = name;
        }
        public Suffix(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }



    public class Category : Suffix
    {
        public Category(string name) : base(name)
        {
        }
        public Category(int id, string name) : base(id, name)
        {
        }
    }

    public class SubCategory : Suffix
    {

        public SubCategory(string name) : base(name)
        {
           
        }
        public SubCategory(int id, string name) : base(id, name)
        {
        
        }
    }

    public class Unit : Suffix
    {
        public Unit(string name) : base(name)
        {

        }
        public Unit(int id, string name) : base(id, name)
        {
 
        }
    }

    public enum ProductSuffix 
    {
        category,
        subcategory,
        unit
    }
}
