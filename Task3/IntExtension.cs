using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class IntExtension
    {
        public static string ToUpperXexString(this int numb)
        {
            return string.Format("{0:X}", numb);
        }
        public static string ToLowerXexString(this int numb)
        {
            return string.Format("{0:x}", numb);

        }
    }
}
