using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    [TestClass]
    public class UnitTestStudent
    {
        Student student = new Student(0, "moophy");
        [TestMethod]
        public void TestCtor()
        {
            var s = new Lib.Student(1,"alan");
        }

        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual("[moophy](0)", student.ToString());
        }
    }
}
