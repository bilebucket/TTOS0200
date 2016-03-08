using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw06
{
    class Tablet : Electronics
    {
        public int Guarantee { get; set; }

        public Tablet(string ProductName, string Brand, float ScreenSize, int Guarantee)
            : base(ProductName, Brand, ScreenSize)
        {
            this.Guarantee = Guarantee;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Guarantee: " + Guarantee + "-year");
        }
    }
}
