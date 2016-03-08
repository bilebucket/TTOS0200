using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw06
{
    class Electronics
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public float ScreenSize { get; set; }
       

        public Electronics(string ProductName, string Brand, float ScreenSize)
        {
            this.ProductName = ProductName;
            this.Brand = Brand;
            this.ScreenSize = ScreenSize;
        }

        public virtual void PrintData()
        {
            Console.WriteLine("Product name: " + ProductName);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Screen size: " + ScreenSize);
        }
    }
}
