/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB
{
    class Vehicle
    {
        public string name { get; set; }
        public int speed { get; set; }
        public int tyres { get; set; }

        public Vehicle(string name, int speed, int tyres)
        {
            this.name = name;
            this.speed = speed;
            this.tyres = tyres;
        }

        public void PrintData()
        {
            Console.WriteLine(ToString());
            
        }

        public override string ToString()
        {
            return name + " " + speed + " " + tyres;
        }
    }

    class Exercise4
    {
        static void Main(string[] args)
        {
            Vehicle truck = new Vehicle("John Deere", 200, 16);
            truck.PrintData();
            truck.name = "Car";
            truck.PrintData();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB
{
    class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public float average { get; set; }
        public string school { get; set; }

        public Student(string name, int age, float average, string school)
        {
            this.name = name;
            this.age = age;
            this.average = average;
            this.school = school;
        }
    }

    class Exercise5
    {
        static void Main(string[] args)
        {
            string[] Students = new string[5];

            Student person1 = new Student("student1", 10, 4.1f, "school1");       
            Students[0] = person1.name + " " + person1.age + " " + person1.average + " " + person1.school;
            
            Student person2 = new Student("student2", 11, 5.2f, "school2");
            Students[1] = person2.name + " " + person2.age + " " + person2.average + " " + person2.school; ;

            Student person3 = new Student("student3", 12, 6.3f, "school3");
            Students[2] = person3.name + " " + person3.age + " " + person3.average + " " + person3.school; ;

            Student person4 = new Student("student4", 13, 7.4f, "school4");
            Students[3] = person4.name + " " + person4.age + " " + person4.average + " " + person4.school; ;

            Student person5 = new Student("student5", 14, 8.5f, "school5");
            Students[4] = person5.name + " " + person5.age + " " + person5.average + " " + person5.school; ;

            for ( int  x = 0; x < Students.Length;x++)
            {
                Console.WriteLine(Students[x]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOB
{
    class Alcohol
    {
        public string brand;
        public string type;
        public float alcprc;
        public string container;
        private int Rating;
        public int rating
        {
            get { return Rating; }
            set
            {
                if (value <= MaxRating) { Rating = value; }
                      
            }
        }
        private readonly int MaxRating = 5;

        public Alcohol(string brand, string type, float alcprc, string container, int rating)
        {
            this.brand = brand;
            this.type = type;
            this.alcprc = alcprc;
            this.container = container;
            this.rating = rating;
        }

        public void PrintData()
        {
            Console.WriteLine("Alcohol database : ");
            Console.WriteLine("- Brand : " + brand);
            Console.WriteLine("- Type : " + type);
            Console.WriteLine("- Alcohol procent : " + alcprc);
            Console.WriteLine("- Container : " + container);
            Console.WriteLine("- Rating : " + rating + "\n");
        }
    }

    class Exercise6
    {
        static void Main(string[] args)
        {
            Alcohol alc1 = new Alcohol("brand", "type", 4.7f, "container", 5);
            alc1.PrintData();
        }
    }
}
*/