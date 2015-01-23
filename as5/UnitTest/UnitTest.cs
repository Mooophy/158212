using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    [TestClass]
    public class UnitTestStudent
    {
        [TestMethod]
        public void TestCtor()
        {
            Student student = new Student(0, "moophy", new DateTime(), "some street");
            Assert.AreEqual(0, student.Id);
            Assert.AreEqual("moophy", student.Name);
            Assert.AreEqual(new DateTime(), student.BirthDate);
            Assert.AreEqual("some street", student.Address);
        }

        [TestMethod]
        public void TestToString()
        {
            Student student = new Student(0, "moophy", new DateTime(), "some street");
            Assert.AreEqual("[moophy](0)(0001/1/1 0:00:00)(some street)",student.ToString());
        }
    }

    [TestClass]
    public class UnitTestPaper
    {
        [TestMethod]
        public void TestCtor()
        {
            var paper = new Lib.Paper("some paper", 0, "some one");
            Assert.AreEqual("some paper", paper.Name);
            Assert.AreEqual(0, paper.Number);
            Assert.AreEqual("some one", paper.Coordinator);
        }
    }

    [TestClass]
    public class UnitTestUniversity
    {
        [TestMethod]
        public void TestDefaultCtor()
        {
            var university = new University();
        }
    }
}
