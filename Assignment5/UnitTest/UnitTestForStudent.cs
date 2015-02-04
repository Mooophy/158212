using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace UnitTest
{
    /// <summary>
    /// For Class Student
    /// </summary>
    [TestClass]
    public class UnitTestForStudent
    {
        /// <summary>
        /// Ctor
        /// </summary>
        [TestMethod]
        public void TestCtor()
        {
            var student = new Student<Int64>(0, "moophy", new DateTime(), "some street");
            Assert.AreEqual(0, student.Id);
            Assert.AreEqual("moophy", student.Name);
            Assert.AreEqual(new DateTime(), student.BirthDate);
            Assert.AreEqual("some street", student.Address);
        }
        /// <summary>
        /// simplified ctor
        /// </summary>
        [TestMethod]
        public void TestCtorWithOneArgument()
        {
            var student = new BackEnd.Student<long>(123456);
            Assert.AreEqual(123456, student.Id);
            Assert.AreEqual("_", student.Name);
            Assert.AreEqual("_", student.Address);
        }
        /// <summary>
        /// for ToString
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            var student = new Student<Int64>(0, "ann", new DateTime(), "some street");
            Assert.AreEqual("0,ann,0001/1/1 0:00:00,some street", student.ToString());
        }
        /// <summary>
        /// for CompareTo
        /// </summary>
        [TestMethod]
        public void TestCompareTo()
        {
            var andrea = new Student<Int64>(0, "andrea", new DateTime(), "some street");
            var lee = new Student<Int64>(0, "1ee", new DateTime(), "some street");
            Assert.AreEqual(0, andrea.CompareTo(lee));
        }
    }
}
