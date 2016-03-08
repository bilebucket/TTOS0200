using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Hw06
{
    class Invoice
    {
        public string Customer { get; set; }     
        List<InvoiceItem> products = new List<InvoiceItem>();

        public Invoice(string customer)
        {
            Customer = customer;
        }

        public void AddItem(InvoiceItem item)
        {
            products.Add(item);
        }
               
        public void PrintInvoice()
        {
            Console.WriteLine("Customer " + Customer + " invoice");       
            foreach(InvoiceItem c in products)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine(Total());
        }

        public string Total()
        {
            double x = 0;
            foreach(InvoiceItem p in products)
            {
                x += p.Total;
            }
            return "Sum of InvoiceItem Total's " + x;
        }
    }
}
