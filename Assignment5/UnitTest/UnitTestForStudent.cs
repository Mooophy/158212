using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForStudent
    {
        [TestMethod]
        public void TestCtor()
        {
            var student = new Student<Int64>(0, "moophy", new DateTime(), "some street");
            Assert.AreEqual(0, student.Id);
            Assert.AreEqual("moophy", student.Name);
            Assert.AreEqual(new DateTime(), student.BirthDate);
            Assert.AreEqual("some street", student.Address);
        }

        [TestMethod]
        public void TestToString()
        {
            var student = new Student<Int64>(0, "moophy", new DateTime(), "some street");
            Assert.AreEqual("0,moophy,0001/1/1 0:00:00,some street", student.ToString());
        }

        [TestMethod]
        public void TestCompareTo()
        {
            var andrea = new Student<Int64>(0, "andrea", new DateTime(), "some street");
            var lee = new Student<Int64>(0, "1ee", new DateTime(), "some street");
            Assert.AreEqual(0, andrea.CompareTo(lee));
        }
    }
}
