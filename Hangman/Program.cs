using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.run();
            Console.ReadLine();
        }
    }

    class Game
    {
        private string[] words = { "banana" };
        private Random randGen = new Random();

        public Game()
        {

        }

        public void run()
        {
            int index = randGen.Next(words.Length);
            string word = words[index];
            int guesses = 7;
            char[] hidden = new char[word.Length];
            
            for (int i = 0; i < word.Length; i++)
            {
                hidden[i] = '_';
            }

            while (guesses > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nGuesses: " + guesses);
                Console.ResetColor();
                Console.WriteLine(new String(hidden));
                char g;

                Console.Write("enter guess [one (1) char]> ");

                try
                { 
                    g = char.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou broke it :(\n\nERROR:\n" + e);
                    Console.ResetColor();
                    this.run();
                    break;
                }
        

                bool fail = true;
                
                for (int i=0; i < word.Length; i++)
                {
                    if(word[i] == g)
                    {
                        hidden[i] = g;
                        fail = false;
                    }
                }

                if (fail)
                {
                    guesses--;
                } else {
                    if(new String(hidden).Equals(word))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("WOW! You win the game!");
                        break;
                    }
                }
            }
        }
    }
}
