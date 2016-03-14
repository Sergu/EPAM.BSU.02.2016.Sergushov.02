using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3Tests
{
    [TestClass]
    public class IntExtensionTests
    {
        [TestMethod]
        public void ToUpperXexString_15toXexString_returnString()
        {
            int number = 15;
            string result = "F";
            Assert.AreEqual(number.ToUpperXexString(), result);
        }
        [TestMethod]
        public void ToLowerXexString_15toXexString_returnString()
        {
            int number = 15;
            string result = "f";
            Assert.AreEqual(number.ToLowerXexString(), result);
        }
    }
}
