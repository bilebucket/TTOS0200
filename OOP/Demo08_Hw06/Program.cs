using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Hw06
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Kirsi Kernel");
            invoice.AddItem(new InvoiceItem("Milk", 1.75d, 2d));
            invoice.AddItem(new InvoiceItem("Beer", 5.25d, 3d));
            invoice.PrintInvoice();
        }
    }
}
