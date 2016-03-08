using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_Hw04
{
    class Vehicle
    {
        private List<Engine> Engines;
        public string Brand { get; set; }
        public string Model { get; set; }
        

        public void AddEngine(Engine s)
        {
            Engines.Add(s);
        }

        public void RemoveEngine()
        {
            Engines.Clear();
        }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;

            Engines = new List<Engine>();

            AddEngine(new Engine("General Motors", 300, 2500));
        }

        public override string ToString()
        {
            string s = "Vehicle: " + Brand + " " + Model;

            foreach (Engine x in Engines)
            {
                s += "\n";
                s += x.ToString();
            }
            return s;
        }

    } 
}
