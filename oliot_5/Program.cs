using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliot_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("seconds> ");
            int secondsInput = Int32.Parse(Console.ReadLine());
            int hours = secondsInput / 3600;
            int minutes = (secondsInput % 3600) / 60;
            int seconds = (secondsInput % 3600) % 60;
            Console.WriteLine(hours + " hours, " + minutes + " minutes, " + seconds + " seconds");
            Console.ReadLine();
        }
    }
}
