using System;

/*

*/

namespace oliot_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numStrings = { "one", "two", "three" };
            int input = Int32.Parse(Console.ReadLine()) - 1;
            if(input < numStrings.Length)
            {
                Console.WriteLine(numStrings[input]);
            } else {
                Console.WriteLine("some other number");
            }
            Console.ReadLine();
        }
    }
}