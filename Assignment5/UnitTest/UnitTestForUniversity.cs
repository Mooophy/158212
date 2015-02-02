using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForUniversity
    {
        [TestMethod]
        public void TestMethodCtor()
        {
            var uni = new BackEnd.University();

            Assert.AreEqual(0, uni.Students.Count, "Oops..");
            Assert.AreEqual(0, uni.Papers.Count, "Oops..");
            Assert.AreEqual(0, uni.Enrollments.Count, "Oops..");
        }

        [TestMethod]
        public void TestMethodAddStudent()
        {
            var uni = new BackEnd.University();

            var ann = new BackEnd.Student<long>(42, "Ann", new DateTime(), "China");
            uni.Add(ann);
            Assert.AreEqual(1, uni.Students.Count);

            var seq = Enumerable.Range(13, 50).Where(n => (n & 0x01) == 1).Select(x => x * x);
            foreach (var num in seq)
                uni.Add(new BackEnd.Student<long>(num, "Ann", new DateTime(), "China"));
            Assert.AreEqual(26, uni.Students.Count);

            foreach (var num in Enumerable.Range(0, 10))
                uni.Add(ann);
            Assert.AreEqual(26, uni.Students.Count);
        }
    }
}
