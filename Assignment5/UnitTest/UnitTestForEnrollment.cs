using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace UnitTest
{
    /// <summary>
    /// for class  Enrollments
    /// </summary>
    [TestClass]
    public class UnitTestForEnrollment
    {
        /// <summary>
        /// Ctor with id
        /// </summary>
        [TestMethod]
        public void TestCtorById()
        {
            var e = new BackEnd.Enrollment<Int64>(158212, 1234567890);
            Assert.AreEqual(158212, e.PaperCode);
            Assert.AreEqual(1234567890, e.StudentId);
        }
        /// <summary>
        /// instance ctor
        /// </summary>
        [TestMethod]
        public void TestCtorByInstance()
        {
            var student = new BackEnd.Student<Int64>(1234567890, "zz", new DateTime(), "China");
            var AppDev = new BackEnd.Paper<Int64>(158212, "App Dev", "some cute guy");
            var e = new BackEnd.Enrollment<Int64>(AppDev, student);

            Assert.AreEqual(158212, e.PaperCode);
            Assert.AreEqual(1234567890, e.StudentId);
        }
        /// <summary>
        /// overriding for ToString
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            var e = new BackEnd.Enrollment<Int64>(158212, 1234567890);
            Assert.AreEqual("158212,1234567890", e.ToString());
        }
    }
}
