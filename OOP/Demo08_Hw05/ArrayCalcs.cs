using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Hw05
{
    public class ArrayCalcs
    {
        public static int x;

        public static void Sum(double[] array)
        {
            double x = array.Sum();
            Console.WriteLine("Sum: " + x);
        }

        public static void Avg(double[] array)
        {
            double x = array.Average();
            Console.WriteLine("Average: " + x);
        }

        public static void Min(double[] array)
        {
            double x = array.Min();
            Console.WriteLine("Min: " + x);
        }

        public static void Max(double[] array)
        {
            double x = array.Max();
            Console.WriteLine("Max: " + x);
        }
    }
}
