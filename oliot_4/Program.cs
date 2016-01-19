using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliot_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("age: ");
            int age = Int32.Parse(Console.ReadLine());
            if(age < 18)
            {
                Console.WriteLine("Minor");
            } else if (18 <= age && age < 66)
            {
                Console.WriteLine("Adult");
            } else
            {
                Console.WriteLine("Senior");
            }
            Console.ReadLine();
        }
    }
}
