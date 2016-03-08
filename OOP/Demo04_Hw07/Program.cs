using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw07
{
    class Program
    {
        static void Main(string[] args)
        {
            People example = new People();
            example.Talk();

            People fin1 = new Finn("Matti", 23, "Finland");
            Console.WriteLine(fin1.Name + " " + fin1.Age + " " + fin1.Country);
            fin1.Talk();

            People swe1 = new Swedish("Oliver", 18, "Sweden");
            Console.WriteLine(swe1.Name + " " + swe1.Age + " " + swe1.Country);
            swe1.Talk();
        }
    }
}
