using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliot_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = Double.Parse(Console.ReadLine());
            double usage, cost;
            usage = distance / 100 * 7.02;
            cost = usage * 1.595;
            Console.WriteLine("usage: " + usage + ", cost: " + cost);
            Console.ReadLine();
        }
    }
}
