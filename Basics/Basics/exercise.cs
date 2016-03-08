/*
using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
           int num;
            Console.Write("Give number between 1-3: ");
            num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 3)
                Console.WriteLine("You gave number: " + num);
            else
                Console.WriteLine("Something else"); 
        }
    }
}

using System;

namespace Exercise2a
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int score;
            Console.Write("Give your score: ");
            score = int.Parse(Console.ReadLine());
            if (score >= 0 && score <= 1)
                Console.WriteLine("Your score is 0");
            else if (score >= 2 && score <= 3)
                Console.WriteLine("Your score is 1");
            else if (score >= 4 && score <= 5)
                Console.WriteLine("Your score is 2");
            else if (score >= 6 && score <= 7)
                Console.WriteLine("Your score is 3");
            else if (score >= 8 && score <= 9)
                Console.WriteLine("Your score is 4");
            else if (score >= 10 && score <= 12)
            {
                Console.WriteLine("Your score is 5");
                Console.WriteLine("Good Job!");
            }
            else Console.WriteLine("Not a right score");
        }
    }
}

using System;

namespace Exercise2b
{
    class Program
    {
        static void Main(string[] args)
        {

            int score;

Console.WriteLine("Score:");
            score = int.Parse(Console.ReadLine());

            switch (score)
            {
                case 0:
                case 1:
                    Console.WriteLine("0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("5\nGood Job!");
                    break;
                default:
                    Console.WriteLine("Not a right score");
                    break;
            }
        }
    }
}

using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Give three number: \n");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("sum: " + (a + b + c));
            Console.WriteLine("average :" + ( a + b + c) / 3);
        }
    }
}

using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Tell your age: ");
            age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 17)
                Console.WriteLine("Underage");
            else if (age >= 18 && age <= 65)
                Console.WriteLine("Adult");
            else if(age > 65)
                Console.WriteLine("Senior");
            else
                Console.WriteLine("You are not born yet");
        }
    }
}

using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int GivenSeconds;
            Console.WriteLine("Time in seconds: ");
            GivenSeconds = int.Parse(Console.ReadLine());
            int hours = GivenSeconds / 3600;
            int minutes = GivenSeconds / 60 - hours * 60;
            int seconds = GivenSeconds % 60;
            Console.WriteLine("{0} hours {1} minutes {2} seconds", hours, minutes, seconds);
        }
    }
}

using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance;
            Console.WriteLine("distance: ");
            distance = float.Parse(Console.ReadLine());
            float gas = (float)7.02 / 100 * distance;
            float price = gas * (float)1.595;
            Console.WriteLine("Gas: {0}, Price: {1}", gas, price);
        }
    }
}

using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Year: ");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("Leap year!");
            else
                Console.WriteLine("Not Leep Year!");
        }
    }
}

using System;

namespace Exercise8
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Give three number: ");
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());
            if (numA > numB && numA > numC)
                    Console.WriteLine("\nLargest: " + numA);
            if (numB > numA && numB > numC)
                    Console.WriteLine("\nLargest: " + numB);
                else
                    Console.WriteLine("\nLargest: " + numC);
        }
    }
}

using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num;
            bool running = true;
            while (running)
            {                                
                Console.WriteLine("Give a number: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num == 0)
                {
                    Console.WriteLine(sum);
                    running = false;
                }
            }
        }
    }
}

using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (i = 0; i <= 8; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i] + ": HEP");
                else if (numbers[i] % 2 != 0)
                    Console.WriteLine(numbers[i]);
            }
        }
    }
}

using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int column;
            int line;
            Console.WriteLine("Give a number: ");
            num = int.Parse(Console.ReadLine());
            for (line = 1; line <= num; line++)
            {
                column = 1;
                for (column = 1; column < line; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}

using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [5];
            int i;
            int k;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Give a number ");
                numbers[i] = int.Parse(Console.ReadLine());            
            }
            for (k = 4; k >= 0; k--)
            {
                Console.WriteLine("{0}", numbers[k].ToString());
            }
        }
    }
}

using System;       

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int i, j, min, x = 5, sum = 0;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Points: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < x - 1; i++)
            {
                min = i;
                for (j = i + 1; j < x; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }
                int help = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = help;
            }
            Console.WriteLine("Sort: ");
            for (int l = 0; l < 5; l++)
            {
                Console.Write(numbers[l] + " ");
            }                    
            Console.WriteLine("Total points: ");
            sum = numbers[1] + numbers[2] + numbers[3];
            Console.WriteLine("Sum: " + sum);
        }
    }
}

using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 0, 0, 0, 0, 0, 0 };
            int num;
            while (true)
            {
                Console.WriteLine("Score: ");
                num = int.Parse(Console.ReadLine());
                if (num < 0 || num > 5)
                {
                    break;
                }
                score[num]++;
            }
            for (int i = 0; i < 6;i++)
            {
                Console.Write(i + ":");
                for (int k = 0; k < score[i]; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num - 2; i++)
            {
                for (int x = 0; x < num - i - 3; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < num - 3; x++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomnum = random.Next(1, 100);
            int usernum;
            int guesses = 0;
            while (true)
            {
                guesses++;
                Console.Write("Guess a number: ");
                usernum = int.Parse(Console.ReadLine());
                if (usernum > randomnum)
                    Console.WriteLine("Number is smaller\n");
                else if (usernum < randomnum)
                    Console.WriteLine("Number is higher\n");
                else
                {
                    Console.WriteLine("Correct\n");
                    break;
                }              
            }
            Console.WriteLine("Guesses: " + guesses);
        }
    }
}

using System;
using System.Linq;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableA = { 204, 3, 8, 86, 7};
            int[] tableB = { 1, 64, 4, 22, 11};
            var tableAB = tableA.Concat(tableB).ToArray();
            int i;
            int j;
            int min;
            int x = 10;          

            for (i = 0; i < x - 1; i++)
            {
                min = i;
                for (j = i + 1; j < x; j++)
                {
                    if (tableAB[j] < tableAB[min])
                    {
                        min = j;
                    }
                }
                int help = tableAB[i];
                tableAB[i] = tableAB[min];
                tableAB[min] = help;
            }

            Console.Write("Table A: ");
            for (int l = 0; l < 5; l++)
            {
                Console.Write(tableA[l] + " ");
            }

            Console.Write("\nTable B: ");
            for (int l = 0; l < 5; l++)
            {
                Console.Write(tableB[l] + " ");
            }

            Console.Write("\nTable A + B Sorted: ");
            for (int l = 0; l < 10; l++)
            {
                Console.Write(tableAB[l] + " ");
            }
        }
    }
}

using System;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, reverse = null;
            Console.WriteLine("Enter string");
            word = Console.ReadLine();
            word = word.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i].ToString();
            }
            if (reverse == word)          
            {
                Console.WriteLine("Palindrome - YES");
                Console.WriteLine("Original: " + word + " | Reverse: " + reverse);
            }
            else
            {
                Console.WriteLine("Palindrome - NO");
                Console.WriteLine("Original: " + word + " | Reverse: " + reverse);
            }
        }
    }
}

using System;
using System.Linq;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordBank = { "banana", "orange", "watermelon", "apple", "lemon", "kiwi"};
            Random randGen = new Random();
            int random = randGen.Next(wordBank.Length);
            string randomWord = wordBank[random];
            char[] hidden = new char[randomWord.Length];
            for (int i = 0; i < randomWord.Length; i++)
            {
                hidden[i] = '_';
            }
            int lives = 7;                                                                                 
            Console.WriteLine("HANGMAN");                                                                   
            Console.Write("Guess a letter: ");
            while (true)
            {
                
                char playerGuess = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("Lives: " + lives);

                bool fail = true;

                for (int k = 0; k < randomWord.Length; k++)
                {
                    if (playerGuess == randomWord[k])
                    {
                        hidden[k] = playerGuess;
                        fail = false;
                    }
                }
                Console.WriteLine(hidden);
                if (new string(hidden) == randomWord)
                {
                    Console.WriteLine("You won!");
                    Console.ReadLine();
                    break;
                }
                if (fail)
                {
                    Console.WriteLine("Wrong!");
                    lives--;
                }
                if (lives == 0)
                {
                    Console.WriteLine("You lost! The word is: " + randomWord);
                    break;
                }
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filename = "cat.txt";
            string inputString = File.ReadAllText(@"C:\Users\Hea7hcliff\Documents\School\GitHub\C#\Basics\cat.txt"); 
            inputString = inputString.ToLower();
            string[] deleteChars = { ";", ",", ".", "-", "_", "^", "'",
                        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n"};
            foreach (string character in deleteChars)
            {
                inputString = inputString.Replace(character, "");
            }
            List<string> wordList = inputString.Split(' ').ToList();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in wordList)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary[word] = 1;
                }
            }
            int count = 1;
            var sortedDict = (from entry in dictionary orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
            Console.WriteLine("Most used words in 'cat' story.\n");
            foreach (KeyValuePair<string, int> pair in sortedDict)
            {
                Console.WriteLine(count + "\t" + pair.Key + "\t" + pair.Value);
                count++;
                if (count > 10)
                {
                    break;
                }
            }
        }
    }
}
*/



