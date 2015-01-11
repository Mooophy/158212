﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    using Seq = List<string>;
    using DicOcc = Dictionary<string, int>;
    
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod_BuildOccu()
        {
            var li = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var c  = new Lib.Controller();
            var occu = c.BuildOccu(li);
            Assert.AreEqual(1, occu["cc"]);
            Assert.AreEqual(2, occu["aa"]);
            Assert.AreEqual(3, occu.Count);
        }

        [TestMethod]
        public void TestMethod_BuildLeng()
        {
            var li = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var c = new Lib.Controller();
            var leng = c.BuildLeng(li);
            Assert.AreEqual(1, leng.Count);
            Assert.AreEqual(5, leng[2].Count);
        }

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
