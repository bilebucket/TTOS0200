using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer w = new Writer();
            w.run();
        }
    }

    class Writer
    {

        private static String INT_FILE = "ints.txt";
        private static String DOUBLE_FILE = "doubles.txt";

        public Writer()
        {

        }

        public void write_int(int i)
        {
            try
            {
                using (System.IO.StreamWriter w = System.IO.File.AppendText(INT_FILE))
                {
                    w.WriteLine(i);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void write_double(double i)
        {
            try
            {
                using (System.IO.StreamWriter w = System.IO.File.AppendText(DOUBLE_FILE))
                {
                    w.WriteLine(i);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void run()
        {
            bool running = true;
            while(running)
            {
                Console.Write("> ");
                String input = Console.ReadLine();

                try
                {
                    int i = int.Parse(input);
                    write_int(i);
                    continue;
                }
                catch (FormatException)
                {
                }

                try
                {
                    double i = double.Parse(input);
                    write_double(i);
                }
                catch (FormatException)
                {
                    running = false;
                }
            }

            try
            {
                string text = System.IO.File.ReadAllText(INT_FILE);
                System.Console.WriteLine("Contents of ints.txt:\n" + text);
                text = System.IO.File.ReadAllText(DOUBLE_FILE);
                System.Console.WriteLine("Contents of doubles.txt:\n" + text);
            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadLine();
        }
    }
}
