using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_Hw04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Opel", "2z421i2");
            // vehiclessä lisätty moottori
            Console.WriteLine(vehicle1.ToString() + "\n");
            // poistetaan moottori
            vehicle1.RemoveEngine();
            Console.WriteLine(vehicle1.ToString() + "\n");
            // lisätään uusi
            vehicle1.AddEngine(new Engine("General Motors", 200, 1500));
            Console.WriteLine(vehicle1.ToString());
        }
    }
}
