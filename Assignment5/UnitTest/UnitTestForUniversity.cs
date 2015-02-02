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

            foreach (var _ in Enumerable.Range(0, 10))
                uni.Add(ann);
            Assert.AreEqual(26, uni.Students.Count);
        }

        [TestMethod]
        public void TestMethodAddPaper()
        {
            var uni = new BackEnd.University();
            var app = new BackEnd.Paper<long>(158212, "App Dev", "Mr. Cool");
            uni.Add(app);
            Assert.AreEqual(1, uni.Papers.Count);

            foreach(var _ in Enumerable.Range(0,10))
                uni.Add(app);
            Assert.AreEqual(1, uni.Papers.Count);
        }

        [TestMethod]
        public void TestMethodAddRangeStudents()
        {
            var uni = new BackEnd.University();
            var students = from id in Enumerable.Range(1300000, 100).Select(i => i * i)
                           select (new BackEnd.Student<long>(id, "some guy" + id.ToString(), DateTime.Now, "some where"));
            uni.AddRange(students);

            Assert.AreEqual(100, uni.Students.Count);
        }

        [TestMethod]
        public void TestMethodAddRangePappers()
        {
            var uni = new BackEnd.University();
            var papers = from code in Enumerable.Range(159000, 1000)
                         select (new BackEnd.Paper<long>(code, "paper " + code.ToString(),"Lee"));
            uni.AddRange(papers);

            Assert.AreEqual(1000, uni.Papers.Count);
        }

        [TestMethod]
        public void TestMethodFindPaper()
        {
            var uni = new BackEnd.University();
            var papers = from code in Enumerable.Range(159000, 1000)
                         select (new BackEnd.Paper<long>(code, "paper " + code.ToString(), "Lee"));
            uni.AddRange(papers);

            Assert.AreEqual("Lee", uni.FindPaper(159050).Coordinator);
            Assert.AreEqual("paper 159050", uni.FindPaper(159050).Name);
        }

        [TestMethod]
        public void TestMethodFindStudent()
        {
            var uni = new BackEnd.University();
            var students = from id in Enumerable.Range(120000, 100)
                           select (new BackEnd.Student<long>(id, "some guy " + id.ToString(), DateTime.Now, "some where"));
            uni.AddRange(students);

            Assert.AreEqual(120000, uni.FindStudent(120000).Id);
            Assert.AreEqual("some guy 120050", uni.FindStudent(120050).Name);
        }

        //[TestMethod]
        //public void TestMethodEnrol()
        //{
        //    var uni = new BackEnd.University();
        //    var students = from id in Enumerable.Range(0, 10000)
        //                   select (new BackEnd.Student<long>(id, "_", DateTime.Now, "_"));
        //    uni
        //}
    }
}
