using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class IntExtension
    {
        public static string ToXexString(this int i)
        {
            return string.Format("{0:X}", i);
        }
    }
}
