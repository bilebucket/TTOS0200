using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Hw03
{
    class Card
    {
        public Suits Suit;
        public string Cardvalue;

        public Card(Suits suit, string cardvalue)
        {
            Suit = suit;
            Cardvalue = cardvalue;
        }

        public override string ToString()
        {
            return Cardvalue + " " + Suit;
        }      
    }
}
