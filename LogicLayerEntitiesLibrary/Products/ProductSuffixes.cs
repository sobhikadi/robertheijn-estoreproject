using LogicLayerEntitiesLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public class Suffix 
    {
        private string name;
        public int Id { get; set; }
        public string Name { get { return name; } private set 
            {
                if (string.IsNullOrEmpty(value)) throw new NullValueException("The field suffix cannot be empty");
                if (value.Length < 3 || value.Length > 30) throw new OutOfrangeException("suffix must have at least 3 charachters and maximum of 30 charachters");
                name = value;
            } }
        public SuffixType SuffixType { get; private set; }

        public Suffix(string name, SuffixType type)
        {
            Name = name;
            SuffixType = type;
        }
        public Suffix(int id, string name, SuffixType type)
        {
            Id = id;
            Name = name;
            SuffixType = type;
        }

        public override string ToString()
        {
            return name;
        }
    } 
    
}
