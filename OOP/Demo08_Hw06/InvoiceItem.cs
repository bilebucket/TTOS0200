using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Hw06
{
    class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Total
        {
            get
            {
                return Price * Quantity;
            }
        }

        public InvoiceItem(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + " " + Price + "e " + Quantity + " pieces " + Total + "e total";
        }
    }
}
