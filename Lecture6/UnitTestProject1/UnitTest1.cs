using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testProperResult()
        {
            Calculator cal = new Calculator();
            double x = cal.divide("30", "50");
            Assert.AreEqual(0.6, x);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testZeroDivision()
        {
            var cal = new Calculator();
            double y = cal.divide("8", "0");
        }           
    }
}
