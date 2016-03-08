using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw05
{
    class Exercice5
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            Console.WriteLine("Power: " + radio.Power);
            radio.Power = true;
            Console.WriteLine("Power: " + radio.Power);

            Console.WriteLine("Volume: " + radio.Volume);
            radio.Volume = 9;
            Console.WriteLine("Volume: " + radio.Volume);

            Console.WriteLine("Freq: " + radio.Frequency);
            radio.Frequency = 1900.1;
            Console.WriteLine("Freq: " + radio.Frequency);
        }
    }
}
