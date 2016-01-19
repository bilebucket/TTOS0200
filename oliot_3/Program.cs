using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliot_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine()), num2 = Int32.Parse(Console.ReadLine()), num3 = Int32.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3;
            int avg = sum / 3;
            Console.WriteLine("sum: " + sum + ", avg: " + avg);
            Console.ReadLine();
        }
    }
}
