using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Products
{
    public class Discount
    {
        public int Id { get; private set; }
        public string Slogan { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public double DiscountAmount { get; private set; }
        public BonusRules BonusRule { get; private set; }

    }
}
