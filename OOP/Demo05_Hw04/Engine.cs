using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_Hw04
{
    class Engine
 
    {
        public string Manufacturer { get; set; }
        public int HorsePower { get; set; }
        public int CubicCapacity { get; set; }
        

        public Engine(string mf, int hp, int cc)
        {
            Manufacturer = mf;
            HorsePower = hp;
            CubicCapacity = cc;
        }

        public override string ToString()
        {
            return "Engine: " + Manufacturer + " " + HorsePower + " " + CubicCapacity;
        }
    }


}
