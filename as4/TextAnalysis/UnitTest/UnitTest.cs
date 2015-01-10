using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var li = new List<string> { "aa", "bb"};
            var cl = new Lib.Controller(li);
            Assert.AreEqual("aa bb ", cl.ToString());
            Assert.AreEqual(1, cl.howOften("aa"));
            Assert.AreEqual(0, cl.howOften("cc"));
        }
    }
}
