using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task4
{
    public class Customer : IFormattable
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }
        public Customer(string name, string contactPhone, decimal revenue)
        {
            this.Name = name;
            this.Revenue = revenue;
            this.ContactPhone = contactPhone;
        }
        public Customer() { }
        public override string ToString()
        {
            return this.ToString("nrp", CultureInfo.CurrentCulture);
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (formatProvider != null)
            {
                ICustomFormatter formatter = formatProvider.GetFormat(this.GetType()) as ICustomFormatter;
                if (formatter != null)
                {
                    return formatter.Format(format, this, formatProvider);
                }
                if (format == null)
                {
                    format = "g";
                }
            }

            if (String.IsNullOrEmpty(format)) format = "nrp";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;
            StringBuilder strBuilder = new StringBuilder();
            switch(format.ToLower())
            {
                case "g":
                    return string.Format(Name);
                case "nrp":
                    strBuilder.Append(Name + " ");
                    string str = Revenue.ToString("C",formatProvider);
                    strBuilder.Append(str + " ");
                    strBuilder.Append(ContactPhone + " ");
                    return strBuilder.ToString();
                case "nr":
                    strBuilder.Append(Name + " ");
                    strBuilder.Append(string.Format(formatProvider,"{0:C}",Revenue));
                    return strBuilder.ToString();
                case "n":
                    strBuilder.Append(Name);
                    return strBuilder.ToString();
                case "r":
                    return string.Format(formatProvider,"{0:C}",Revenue);
                default:
                    return string.Format(ContactPhone);

            }
        }
    }
}
