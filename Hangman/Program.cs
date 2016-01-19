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
        private string[] words = { "banana", "pineapple", "watermelon", "lemon" };
        private Random randGen = new Random();
        private String name = "HANGMAN";

        public Game()
        {
        }

        private void printSep(int l)
        {
            string s = "";
            for (int i = 0; i < l; i++)
            {
                s += "#";
            }
            Console.WriteLine(s);
        }

        private void printLogo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            this.printSep(this.name.Length + 2);
            Console.WriteLine("#" + this.name + "#");
            this.printSep(this.name.Length + 2);
            Console.ResetColor();
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

            this.printLogo();

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
                    if (guesses == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nYou lost the game :(((\nThe word was: " + word);
                        Console.ResetColor();
                    }
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
