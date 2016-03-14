using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class CustomerExtension
    {
        public static string ToString(this Customer customer,IFormatProvider formatForName,IFormatProvider formatForPhoneNumber)
        {
            StringBuilder result = new StringBuilder();
            result.Append("Customer : ");
            result.Append(string.Format(formatForName, customer.Name));
            result.Append(", ");
            result.Append(string.Format(formatForPhoneNumber, customer.ContactPhone));

            return result.ToString();
        }
    }
}
