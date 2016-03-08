using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Hw01
{
    class Dice
    {
        public List<int> list = new List<int>();
        public int result;
        static Random r = new Random();

        public void Roll()
        {
            Console.Write("How many times you want to roll the dice? ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("You Rolled " + value + " times.");           
            for (int x = 0; x < value; x++)
            {
                result = r.Next(1, 7);              
                list.Add(result);
            }
            Console.WriteLine("Average: " + list.Average());
        }
    }
}
