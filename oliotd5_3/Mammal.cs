using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliotd5_3
{
    abstract class Mammal
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public String Name { get; set; }

        abstract public void Move(int amount);
        abstract public void Grow();

        public Mammal(int age)
        {
            Age = age;
        }
    }
}
