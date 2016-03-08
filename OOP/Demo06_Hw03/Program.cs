using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Hw03
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            foreach (Card c in deck1.cards)
            {
                Console.WriteLine(c);
            }                                  
        }     
    }
}
