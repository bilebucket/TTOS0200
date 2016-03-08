using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw06
{
    class Program
    {
        static void Main(string[] args)
        {
            Electronics tab1 = new Tablet("Galaxy Tab 10.1", "Samsung", 10.1f, 5);
            tab1.PrintData();
            Console.WriteLine();

            Electronics laptop1 = new Laptop("ZenBook UX305", "ASUS", 13.3f, "Extra battery");
            laptop1.PrintData();
            Console.WriteLine();

            Electronics phone1 = new Phone("Honor 4X", "Huawei", 5.5f, "Earphones");
            phone1.PrintData();
            Console.WriteLine();
        }
    }
}
