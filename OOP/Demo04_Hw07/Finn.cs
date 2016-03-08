using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw07
{
    class Finn : People
    {
        public Finn(string Name, int Age, string Country)
            : base(Name, Age, Country)
        { 
        }

        public override void Talk()
        {
            Console.WriteLine("Finns says: Morjens!\n");
        }
    }
}
