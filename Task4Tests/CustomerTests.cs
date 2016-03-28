using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;
using System.Globalization;

namespace Task4Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void ToString_customObject_returnStringAboutCustomObj()
        {
            Customer customer = new Customer("Ivanov", "4351231", 23);
            string result = "Customer : Ivanov, 4351231, 23";
            Assert.AreEqual(customer.ToString(), result);
        }
        //[TestMethod]
        //public void ToString_customObjectFormatForName_returnStringAboutCustomObj()
        //{
        //    NumberFormatInfo name = new NumberFormatInfo();
        //    name.NumberGroupSeparator = "  ";
        //    Customer customer = new Customer("Ivanov", "4351231", 23);
        //    string result = "Customer : Ivanov";
        //    Assert.AreEqual(customer.ToString(name), result);
        //}
        //[TestMethod]
        //public void ToString_customObjectFormatForNamePhoneNumberRevenue_returnStringAboutCustomObj()
        //{
        //    NumberFormatInfo revenue = new NumberFormatInfo();
        //    revenue.NumberGroupSeparator = "%%";
        //    NumberFormatInfo name = new NumberFormatInfo();
        //    name.NumberGroupSeparator = "--";
        //    NumberFormatInfo phone = new NumberFormatInfo();
        //    phone.NumberGroupSeparator = "..";
        //    Customer customer = new Customer("Ivanov", "4351231", 23);
        //    string result = "Customer : Ivanov, 4351231, 23";
        //    Assert.AreEqual(customer.ToString(name,phone,revenue), result);
        //}
        //[TestMethod]
        //public void ToString_customObjectFormatForNamePhoneNumber_returnStringAboutCustomObj()
        //{
        //    NumberFormatInfo name = new NumberFormatInfo();
        //    name.NumberGroupSeparator = "--";
        //    NumberFormatInfo phone = new NumberFormatInfo();
        //    phone.NumberGroupSeparator = "..";
        //    Customer customer = new Customer("Ivanov", "4351231", 23);
        //    string result = "Customer : Ivanov, 4351231";
        //    Assert.AreEqual(customer.ToString(name, phone), result);
        //}
    }
}
