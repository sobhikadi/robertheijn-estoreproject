using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public class Bonus
    {
        public int Id { get; private set; }
        public string Slogan { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public int QuatityRequired { get; private set; }
        public double Discount { get; private set; }
        public EnumsProduct.BonusRules BonusRule { get; private set; }

    }
}
