using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person s = new Person("John", "Doe");
            s.PersonMethod();
            Console.WriteLine(s.ToString());
        }
    }
}
