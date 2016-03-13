using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using Task3;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            int res = 0;
            try
            {
                res = EuclidType.NodByEuclid(out time, 27273121, 12415235, 23534142);
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    Console.WriteLine("null eXCEPTION");
                }
                if (ex is ArgumentException)
                {
                    Console.WriteLine("argument exception");
                }
            }
            Console.WriteLine("Euclid : numb: {0}, miliSeconds: {1}", res, time);
            res = EuclidType.NodByStein(out time, 27273121, 12415235, 23534142);
            Console.WriteLine("Stein : numb: {0}, miliSeconds: {1}", res, time);
            //Console.ReadKey();
            int i = 22;
            Console.WriteLine("расширение 22 :" + i.ToXexString());
            Console.ReadLine();
        }
    }
}
