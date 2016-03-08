using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw07
{
    class Swedish : People
    {
        public Swedish(string Name, int Age, string Country)
            : base(Name, Age, Country)
        {

        }

        public override void Talk()
        {
            Console.WriteLine("Swedes: Tjänäre!\n");
        }
    }
}
