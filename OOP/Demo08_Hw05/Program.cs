using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Hw05
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            ArrayCalcs.Sum(array);
            ArrayCalcs.Avg(array);
            ArrayCalcs.Min(array);
            ArrayCalcs.Max(array);
        }
    }
}
