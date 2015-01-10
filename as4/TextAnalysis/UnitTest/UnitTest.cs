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
        public void TestMethod_ToString()
        {
            var li = new List<string> { "aa", "bb"};
            var cl = new Lib.Controller(li);
            Assert.AreEqual("aa bb ", cl.ToString());

        }

        [TestMethod]
        public void TestMethod_HowOften()
        {
            var li = new List<string> { "aa", "bb" };
            var cl = new Lib.Controller(li);
            Assert.AreEqual(1, cl.HowOften("aa"));
            Assert.AreEqual(0, cl.HowOften("cc"));
        }

        [TestMethod]
        public void TestMethod_MostCommon()
        {
            var li = new List<string> { "aa", "bb", "aa", "cc","bb" };
            var cl = new Lib.Controller(li);
            var mc = cl.MostCommon();
            Assert.AreEqual(2, mc.Item1);
            Assert.AreEqual(2, mc.Item2.Count);
        }
    }
}
