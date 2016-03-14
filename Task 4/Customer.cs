using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task4
{
    public class Customer
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }
        public Customer(string name,string contactPhone,decimal revenue)
        {
            this.ContactPhone = contactPhone;
            this.Name = name;
            this.Revenue = revenue;
        }
        public Customer() { }
        public override string ToString()
        {
            return string.Format("Customer : {0}, {1}, {2}", this.Name, this.ContactPhone, this.Revenue);
        }
        public string ToString(IFormatProvider formatForName, IFormatProvider formatForContactPhone, IFormatProvider formatForRevenue)
        {
            StringBuilder result = new StringBuilder();
            result.Append("Customer : ");
            result.Append(string.Format(formatForName, this.Name));
            result.Append(", ");
            result.Append(string.Format(formatForContactPhone, this.ContactPhone));
            result.Append(", ");
            result.Append(string.Format("{0}", this.Revenue, formatForRevenue));
            return result.ToString();
        }
        public string ToString(IFormatProvider formatForName)
        {
            StringBuilder result = new StringBuilder();
            result.Append("Customer : ");
            result.Append(string.Format(formatForName, this.Name));
            return result.ToString();
        }
    }
}
