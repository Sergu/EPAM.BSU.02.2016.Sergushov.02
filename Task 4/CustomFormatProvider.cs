using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task4
{
    public class CustomFormatProvider : IFormatProvider, ICustomFormatter
    {
        private IFormatProvider parent;
        public object GetFormat(Type formatType)
        {
            return this;
        }
        public CustomFormatProvider() : this(CultureInfo.CurrentCulture) { }
        public CustomFormatProvider(IFormatProvider parent)
        {
            this.parent = parent;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider) 
        {
            Customer customer = arg as Customer; 
            if(customer == null)
            {
                throw new NullReferenceException();
            }
            StringBuilder strBuilder = new StringBuilder();
            switch(format)
            {
                case "nrp":
                    strBuilder.Append("Customer: " + customer.Name);
                    strBuilder.Append("Revenue: $" + customer.Revenue + " ");
                    strBuilder.Append("Phone: " + customer.ContactPhone);
                    return strBuilder.ToString();
                case "nr":
                    strBuilder.Append("Customer: " + customer.Name);
                    strBuilder.Append("Revenue: $" + customer.Revenue + " ");
                    return strBuilder.ToString();
                case "n":
                    strBuilder.Append("Customer: " + customer.Name);
                    return strBuilder.ToString();
                case "r":
                    strBuilder.Append("Revenue: $" + customer.Revenue + " ");
                    return strBuilder.ToString();
                default:
                    return strBuilder.Append(customer.Name).ToString();
            }

        }
    }
}
