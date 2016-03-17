using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Name = "Jeffrey Richter",
                Revenue = 1000000,
                ContactPhone = "+1 (425) 555-0100"
            };
            Console.WriteLine(customer.ToString());
            Console.WriteLine(customer.ToString("nrp", CultureInfo.GetCultureInfo("en-GB")));
            Console.WriteLine(customer.ToString("nrp", new CustomFormatProvider(CultureInfo.GetCultureInfo("en-GB"))));
            Console.WriteLine(customer.ToString("nrp", new CultureInfo("de-DE")));
            
            
            Console.ReadLine();       
        }
    }
}
