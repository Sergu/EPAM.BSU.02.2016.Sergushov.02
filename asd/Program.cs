using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using Task3;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            HexFormatProvider prov = new HexFormatProvider();
            int a = 342;
            Console.WriteLine(a.ToString("   x", prov));
            Console.WriteLine(string.Format(prov, "x", 15));
            Console.ReadLine();
        }
    }
}
