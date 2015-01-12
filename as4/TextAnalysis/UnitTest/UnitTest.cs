using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    #region Unit tests for class Lib.Controller
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodBuildOccu()
        {
            var li = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var c  = new Lib.Controller();
            var occu = c.BuildOccu(li);
            Assert.AreEqual(1, occu["cc"]);
            Assert.AreEqual(2, occu["aa"]);
            Assert.AreEqual(3, occu.Count);
        }

        [TestMethod]
        public void TestMethodBuildLeng()
        {
            var li = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var c = new Lib.Controller();
            var leng = c.BuildLeng(li);
            Assert.AreEqual(1, leng.Count);
            Assert.AreEqual(3, leng[2].Count);
        }

        [TestMethod]
        public void TestMethodToString()
        {
            var li = new List<string> { "aa", "bb"};
            var c  = new Lib.Controller(li);
            Assert.AreEqual("aa bb ", c.ToString());
        }

        [TestMethod]
        public void TestMethodHowOften()
        {
            var li = new List<string> { "aa", "bb" };
            var c  = new Lib.Controller(li);
            Assert.AreEqual(1, c.HowOften("aa"));
            Assert.AreEqual(0, c.HowOften("cc"));
        }

        [TestMethod]
        public void TestMethodMostCommon()
        {
            var li = new List<string>{ "aa", "bb", "aa", "cc","bb" };
            var c = new Lib.Controller(li);
            var mc = c.MostCommon();
            Assert.AreEqual(2, mc.Item1);
            Assert.AreEqual(2, mc.Item2.Count);
        }

        [TestMethod]
        public void TestMethodLongest()
        {
            var li = new List<string>{"1", "22","22","333","333","333"};
            var c = new Lib.Controller(li);
            Assert.AreEqual(3, c.Longest().Item1);
            foreach (string w in c.Longest().Item2)
                Assert.AreEqual("333", w);
        }

        [TestMethod]
        public void TestMethodShortest()
        {
            var li = new List<string> { "1", "22", "22", "333", "333", "333" };
            var c = new Lib.Controller(li);
            Assert.AreEqual(1, c.Shortest().Item1);
        }

        [TestMethod]
        public void TestMethodAverage()
        {
            var li = new List<string> {"22", "22", "333", "333", "333" };
            var c = new Lib.Controller(li);
            Assert.AreEqual(2, c.Average());
        }

        [TestMethod]
        public void TestMethodLookupByLength()
        {
            var li = new List<string> { "22", "22", "323", "113", "123" };
            var c = new Lib.Controller(li);
            var result = c.LookupByLength(3);
            Assert.AreEqual(3, result.Count);
            foreach (var w in result)
                Assert.AreEqual(3, w.Length);
        }
    #endregion
    }
}
