using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliot_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("points> ");
            int points = Int32.Parse(Console.ReadLine());
            int grade = 0;
            switch(points)
            {
                case 0:
                case 1:
                    grade = 0;
                    break;
                case 2:
                case 3:
                    grade = 1;
                    break;
                case 4:
                case 5:
                    grade = 2;
                    break;
                case 6:
                case 7:
                    grade = 3;
                    break;
                case 8:
                case 9:
                    grade = 4;
                    break;
                case 10:
                case 11:
                case 12:
                    grade = 5;
                    break;
                }
            Console.WriteLine("grade: " + grade);
            Console.ReadLine();
        }
    }
}
