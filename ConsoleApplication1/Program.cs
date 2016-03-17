using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;
using System.Threading;
using System.Globalization;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            HexFormatProvider prov = new HexFormatProvider();
            int a = 0;
            Console.WriteLine(string.Format(prov,"{0:H}",15));
            Console.ReadLine();
        }
    }
}
