using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod_elapsedToString()
        {
            var c = new Lib.Controller();
            Assert.AreEqual("00:01", c.elapsedToString(1));
            Assert.AreEqual("01:00", c.elapsedToString(60));
        }
    }
}
