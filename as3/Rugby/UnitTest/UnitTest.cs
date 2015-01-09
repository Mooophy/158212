using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        Controller c = new Controller();

        [TestMethod]
        public void TestMethod_elapsedToString()
        {
            Assert.AreEqual("00:01", c.elapsedToString(1));
            Assert.AreEqual("01:00", c.elapsedToString(60));
        }

        [TestMethod]
        public void TestMethod_mapPoints()
        {
            Assert.AreEqual(5, c.mapPoints(0));
            Assert.AreEqual(2, c.mapPoints(1));
            Assert.AreEqual(3, c.mapPoints(2));
            Assert.AreEqual(3, c.mapPoints(3));
        }
    }
}
