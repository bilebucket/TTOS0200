using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            Console.WriteLine("Power: " + radio.Power);
            radio.Power = true;
            Console.WriteLine("Power: " + radio.Power);

            Console.WriteLine("Vol: " + radio.Volume);
            radio.Volume = 9;
            Console.WriteLine("Vol: " + radio.Volume);

            Console.WriteLine("Freq: " + radio.Frequency);
            radio.Frequency = 26000.1;
            Console.WriteLine("Freq: " + radio.Frequency);
        }
    }
}
