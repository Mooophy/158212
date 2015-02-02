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
