using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodHello()
        {
            var c = new Lib.Controller();
            Assert.AreEqual("hello", c.hello());
            
        }
    }
}
