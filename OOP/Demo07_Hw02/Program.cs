using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07_Hw02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            double num2;
            System.IO.StreamWriter intfile = new System.IO.StreamWriter("int.txt");
            System.IO.StreamWriter doublefile = new System.IO.StreamWriter("double.txt");
            while (true)
            {
                Console.Write("Give a number: ");
                string value = Console.ReadLine();
                if (int.TryParse(value, out num1))
                {
                    intfile.WriteLine(value);
                }
                else if (double.TryParse(value, out num2))
                {
                    doublefile.WriteLine(value);
                }
                else
                {
                    break;
                }
            }
            intfile.Close();
            doublefile.Close();
            string txt1 = System.IO.File.ReadAllText("int.txt");
            Console.WriteLine("\nContents of int.txt:\n" + txt1 + "\n");
            string txt2 = System.IO.File.ReadAllText("double.txt");
            Console.WriteLine("Contents of double.txt:\n" + txt2);
        }
    }
}
