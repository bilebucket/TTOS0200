using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliotd5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal man = new Human(20);
            man.Move(2);
            man.Grow();            
        }
    }
}
