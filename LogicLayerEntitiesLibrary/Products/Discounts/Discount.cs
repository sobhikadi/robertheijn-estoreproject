using LogicLayerEntitiesLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products.DiscountS
{
    public class Discount 
    {
        string slogan;
        private DateTime startDate, endDate;
        
        public int Id { get; set; }
        public string Slogan { get { return slogan; }
            private set 
            {
                if(string.IsNullOrEmpty(value)) throw new NullValueException("Slogan can not be empty");
            }
        }
        public DateTime StartDateTime { get { return startDate; } 
            private set 
            {
                if(value < DateTime.Now.Date) throw new ArgumentOutOfRangeException("Start date can not be in the past");
                startDate = value;
            } }
        public DateTime EndDateTime { get { return endDate; } 
            private set 
            {
                if (value <= StartDateTime) throw new ArgumentOutOfRangeException("End date should be bigger than start date");
                endDate = value;
            } }
        public int MinimumProducts { get; private set; }
        public double DiscountAmount { get; private set; }

        

        public Discount(string name, DateTime sDateTime, DateTime eDateTime, int minNuProducts, double discount) 
        {
            Slogan = name;
            StartDateTime = sDateTime;
            EndDateTime = eDateTime;
            MinimumProducts = minNuProducts;
            DiscountAmount = discount;
        }

        public Discount(int id, string name, DateTime sDateTime, DateTime eDateTime, int minNuProducts, double discount)
        {
            Id = id;
            Slogan = name;
            StartDateTime = sDateTime;
            EndDateTime = eDateTime;
            MinimumProducts = minNuProducts;
            DiscountAmount = discount;
        }

        

    }
}
