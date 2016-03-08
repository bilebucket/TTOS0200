using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Hw07
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public People()
        {

        }

        public People(string Name, int Age, string Country)
        {
            this.Name = Name;
            this.Age = Age;
            this.Country = Country;
        }

        public virtual void Talk()
        {
            Console.WriteLine("International language: Hello!\n");
        }
    }
}
