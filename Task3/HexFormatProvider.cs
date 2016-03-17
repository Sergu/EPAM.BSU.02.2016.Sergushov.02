using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    public class HexFormatProvider : IFormatProvider,ICustomFormatter
    {
        private IFormatProvider parent;
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            return null;
        }
        public HexFormatProvider() : this(CultureInfo.CurrentCulture) { }
        public HexFormatProvider(IFormatProvider parent)
        {
            this.parent = parent;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider) 
        { 
            int numb = (int)arg;
            switch(format)
            {
                case "X":
                    return HexFormat(numb).ToUpper();
                case "x":
                    return HexFormat(numb).ToLower();
                default:
                    return HexFormat(numb).ToLower();

            }
        }
        private string HexFormat(double numb)
        {
            string[] str = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split();
            string res = "";
            bool Minusflag = false;
            if (numb < 0)
            {
                Minusflag = true;
                numb = numb - 2 * numb;
            }
            int celoe = (int)Math.Round(numb, 0);
            double ost = numb - celoe;

            int o = 0;
            while (celoe != 0)
            {
                res = str[(celoe % 16)] + res;
                celoe = celoe / 16;
            }
            if (Minusflag)
            {
                res = "-" + res;
            }
            return res;
        }
    }
}
