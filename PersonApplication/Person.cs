using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string phoneNumber { get; set; }


        public Person(string fn, string ln)
        {
            firstName = fn;
            lastName = ln;
        }

        public void PersonMethod()
        {
            Console.WriteLine("persons method! wow so advanced!");
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + address + " " + age + " " + phoneNumber;
        }
    }
}
