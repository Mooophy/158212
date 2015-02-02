using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForPaper
    {
        /// <summary>
        /// Constructor
        /// </summary>
        [TestMethod]
        public void TestCtor()
        {
            var paper = new BackEnd.Paper<Int64>( 0, "OO","Boo Boo");
            Assert.AreEqual("OO", paper.Name);
            Assert.AreEqual(0, paper.Code);
            Assert.AreEqual("Boo Boo", paper.Coordinator);
        }

        [TestMethod]
        public void TestSimplifiedCtor()
        {
            var p = new BackEnd.Paper<long>(99999999999999999);
            Assert.AreEqual(99999999999999999, p.Code);
            Assert.AreEqual("_", p.Name);
            Assert.AreEqual("_", p.Coordinator);
        }

        [TestMethod]
        public void TestCompareTo()
        {
            var paper9999 = new BackEnd.Paper<long>(9999);
            var paper8888 = new BackEnd.Paper<long>(8888);
            Assert.AreEqual(9999, paper9999.Code);
            Assert.IsTrue(0 < paper9999.CompareTo(paper8888));
        }

        /// <summary>
        /// ToString Overloaded
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            var paper = new BackEnd.Paper<Int64>(0, "OO", "Boo Boo");
            Assert.AreEqual("0,OO,Boo Boo", paper.ToString());
        }
    }
}
