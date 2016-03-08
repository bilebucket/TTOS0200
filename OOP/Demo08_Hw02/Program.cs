using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Hw02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Milk", 1.4f));
            products.Add(new Product("Beer", 2.2f));
            products.Add(new Product("Butter", 3.2f));
            products.Add(new Product("Cheese", 4.2f));
            Console.WriteLine("All products in collection:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
