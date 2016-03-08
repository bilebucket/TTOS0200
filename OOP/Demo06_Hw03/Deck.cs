using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Hw03
{
    class Deck
    {
        public List<Card> cards;
        string[] numbers = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        
        public Deck()
        {
            cards = new List<Card>();
            
            foreach (string s in numbers)
            {
                cards.Add(new Card(Suits.Hearts, s));
            }

            foreach (string s in numbers)
            {
                cards.Add(new Card(Suits.Diamons, s));
            }

            foreach (string s in numbers)
            {
                cards.Add(new Card(Suits.Spades, s));
            }

            foreach (string s in numbers)
            {
                cards.Add(new Card(Suits.Clubs, s));
            }
        }
    }
}

