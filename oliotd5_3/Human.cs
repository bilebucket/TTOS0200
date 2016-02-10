using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliotd5_3
{
    class Human : Mammal
    {
        public Human(int age)
            : base(age)
        {

        }

        public override void Move(int amount)
        {
            Console.WriteLine("Human moves " + amount + " units");
        }

        public override void Grow()
        {
            Age++;
            Console.WriteLine("Human is " + Age + " years old.");
        }
    }
}
