using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw06
{
    class Phone : Electronics
    {
        public string Supplement { get; set; }

        public Phone(string ProductName, string Brand, float ScreenSize, string Supplement)
            : base(ProductName, Brand, ScreenSize)
        {
            this.Supplement = Supplement;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Extra Supplement: " + Supplement);
        }
    }
}
