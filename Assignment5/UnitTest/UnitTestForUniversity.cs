﻿using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BackEnd;

namespace UnitTest
{
    //type aliasing
    using P = BackEnd.Paper<long>;
    using S = BackEnd.Student<long>;
    using E = BackEnd.Enrollment<long>;
    /// <summary>
    /// For Class University
    /// </summary>
    [TestClass]
    public class UnitTestForUniversity
    {
        /// <summary>
        /// for Ctor
        /// </summary>
        [TestMethod]
        public void TestMethodCtor()
        {
            var uni = new BackEnd.University();
            Assert.AreEqual(0, uni.Students.Count, "Oops..");
            Assert.AreEqual(0, uni.Papers.Count, "Oops..");
            Assert.AreEqual(0, uni.Enrollments.Count, "Oops..");
        }
        /// <summary>
        /// for Add
        /// </summary>
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
        /// <summary>
        /// for Add
        /// </summary>
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
        /// <summary>
        /// for AddRange
        /// </summary>
        [TestMethod]
        public void TestMethodAddRangeStudents()
        {
            var uni = new BackEnd.University();
            var students = from id in Enumerable.Range(1300000, 100).Select(i => i * i)
                           select new BackEnd.Student<long>(id, "some guy" + id.ToString(), DateTime.Now, "some where");
            uni.AddRange(students);

            Assert.AreEqual(100, uni.Students.Count);
        }
        /// <summary>
        /// for AddRange
        /// </summary>
        [TestMethod]
        public void TestMethodAddRangePappers()
        {
            var uni = new BackEnd.University();
            var papers = from code in Enumerable.Range(159000, 1000)
                         select new BackEnd.Paper<long>(code, "paper " + code.ToString(),"Lee");
            uni.AddRange(papers);

            Assert.AreEqual(1000, uni.Papers.Count);
        }
        /// <summary>
        /// for FindPaper
        /// </summary>
        [TestMethod]
        public void TestMethodFindPaper()
        {
            var uni = new BackEnd.University();
            var papers = from code in Enumerable.Range(159000, 1000)
                         select new BackEnd.Paper<long>(code, "paper " + code.ToString(), "Lee");
            uni.AddRange(papers);

            Assert.AreEqual("Lee", uni.FindPaper(159050).Coordinator);
            Assert.AreEqual("paper 159050", uni.FindPaper(159050).Name);
        }
        /// <summary>
        /// for FindStudent
        /// </summary>
        [TestMethod]
        public void TestMethodFindStudent()
        {
            var uni = new BackEnd.University();
            var students = from id in Enumerable.Range(120000, 100)
                           select new BackEnd.Student<long>(id, "some guy " + id.ToString(), DateTime.Now, "some where");
            uni.AddRange(students);

            Assert.AreEqual(120000, uni.FindStudent(120000).Id);
            Assert.AreEqual("some guy 120050", uni.FindStudent(120050).Name);
        }
        /// <summary>
        /// for Enroll
        /// </summary>
        [TestMethod]
        public void TestMethodEnrol()
        {
            var uni = new BackEnd.University();
            var num = 1000;
            var data = 
                Enumerable
                .Range(100100, num)
                .Select(n => new Tuple<P, S>(new P(n), new S(n)))
                .Select(t => uni.Add(t.Item1) && uni.Add(t.Item2) && uni.Enrol(t.Item1.Code, t.Item2.Id));
            
            long count = 0;
            foreach (var _ in data) ++count;
            Assert.AreEqual(num, count);
            Assert.AreEqual(num, uni.Papers.Count);
            Assert.AreEqual(num, uni.Students.Count);
            Assert.AreEqual(num, uni.Enrollments.Count);
        }
        /// <summary>
        /// for Enroll
        /// </summary>
        [TestMethod]
        public void TestMethodEnrolWithLine()
        {
            var uni = new BackEnd.University();
            var num = 500;
            var data =
                Enumerable
                .Range(100100, num)
                .Select(n => new Tuple<P, S>(new P(n), new S(n)))
                .Select(t => uni.Add(t.Item1) && uni.Add(t.Item2) && uni.Enrol(t.Item1.Code.ToString() + "," + t.Item2.Id.ToString()));

            bool isAllTrue = data.All(elem => elem == true);
            Assert.AreEqual(true, isAllTrue);
            Assert.AreEqual(num, uni.Papers.Count);
            Assert.AreEqual(num, uni.Students.Count);
            Assert.AreEqual(num, uni.Enrollments.Count);
        }
        /// <summary>
        /// for FindEnrolled
        /// </summary>
        [TestMethod]
        public void TestMethodFindEnrolledByPaper()
        {
            var uni = new BackEnd.University();
            uni
                .AddRange(Enumerable.Range(0, 50).Select(i => new S(i)));
            uni
                .AddRange(Enumerable.Range(0, 50).Select(i => new P(i)));
            foreach (var p in uni.Papers)
                foreach (var s in uni.Students)
                    uni.Enrol(p.Code, s.Id);

            var isAllTrue = (from p in uni.Papers select uni.FindEnrolledByPaper(p.Code))
                            .All(li => li.Count == 50);
            Assert.IsTrue(isAllTrue);
        }
        /// <summary>
        /// for FindEnrolled
        /// </summary>
        [TestMethod]
        public void TestMethodFindEnrolledByStudent()
        {
            var uni = new BackEnd.University();
            var num = 500;
            var data = 
                Enumerable
                .Range(100100, num)
                .Select(n => new Tuple<P, S>(new P(n), new S(n)))
                .Select(t => uni.Add(t.Item1) && uni.Add(t.Item2) && uni.Enrol(t.Item1.Code.ToString() + "," + t.Item2.Id.ToString()))
                .ToList();
            Assert.AreEqual(num, data.Count);
            Assert.AreEqual(true, data.All(elem => true == elem));
            
            var isTrue =
                uni.Students
                .Select(s => s.Id)
                .Select(id => uni.FindEnrolledByStudent(id))
                .All(list => list.Count == 1);
            Assert.AreEqual(true, isTrue);
        }
        /// <summary>
        /// for generic Export
        /// </summary>
        [TestMethod]
        public void TestMethodExport()
        {
            var data = Enumerable.Range(0, 1000).Select(i => i.ToString());
            var set = new SortedSet<string>(data);
            var uni = new BackEnd.University();
            string folder = Directory.GetCurrentDirectory().ToString();
            uni.Export<string>(set, folder, "TestingExport", "txt");

            Assert.AreEqual(@"G:\ForStudy\forCS\158212\Assignment5\UnitTest\bin\Debug", folder);
            Assert.IsTrue(File.Exists(folder + @"\TestingExport.txt"));
        }
        /// <summary>
        /// for ExportAllData
        /// </summary>
        [TestMethod]
        public void TestMethodExportAllData()
        {
            var uni = new BackEnd.University();
            uni.AddRange(Enumerable.Range(0, 50).Select(i => new S(i)));
            uni.AddRange(Enumerable.Range(0, 50).Select(i => new P(i)));
            foreach (var p in uni.Papers)
                foreach (var s in uni.Students)
                    uni.Enrol(p.Code, s.Id);
            uni.ExportAllData(Directory.GetCurrentDirectory().ToString());
        }
        /// <summary>
        /// for ImportStudents
        /// </summary>
        [TestMethod]
        public void TestMethodImportStudents()
        {
            Action createStudensFile = () =>
            {
                var u = new BackEnd.University();
                u.AddRange(Enumerable.Range(0, 50).Select(i => new S(i)));
                u.Export<S>(u.Students, Directory.GetCurrentDirectory().ToString(), "Students", "csv");
            };

            createStudensFile();
            var uni = new BackEnd.University();
            var count = uni.ImportStudents(Directory.GetCurrentDirectory().ToString() + @"\Students.csv");
            Assert.AreEqual(50, count);
            Assert.AreEqual(50, uni.Students.Count);
        }
        /// <summary>
        /// for ImportPapers
        /// </summary>
        [TestMethod]
        public void TestMethodImportPapers()
        {
            Action createPapersFile = () =>
            {
                var u = new BackEnd.University();
                u.AddRange(Enumerable.Range(0, 10).Select(i => new P(i)));
                u.Export<P>(u.Papers, Directory.GetCurrentDirectory().ToString(), "Papers", "csv");
            };

            createPapersFile();
            var uni = new BackEnd.University();
            var count = uni.ImportPapers(Directory.GetCurrentDirectory().ToString() + @"\Papers.csv");
            Assert.AreEqual(10, count);
            Assert.AreEqual(10, uni.Papers.Count);
        }
        /// <summary>
        /// for ImportEnrollments
        /// </summary>
        [TestMethod]
        public void TestMethodImportEnrollments()
        {
            string folder = Directory.GetCurrentDirectory().ToString();
            Action createEnrollmentsFile = () =>
            {
                var u = new BackEnd.University();
                u.AddRange(Enumerable.Range(0, 50).Select(i => new S(i)));
                u.AddRange(Enumerable.Range(0, 10).Select(i => new P(i)));
                foreach (var code in u.Papers.Where(p => p.Code < 10).Select(p => p.Code))
                    u.Enrol(code, code);//<-the second 'code' standing for student id.

                u.Export<S>(u.Students, folder, "Students", "csv");
                u.Export<P>(u.Papers, folder, "Pappers", "csv");
                u.Export<E>(u.Enrollments, folder, "Enrollments", "csv");
            };

            createEnrollmentsFile();
            var uni = new BackEnd.University();
            uni.AddRange(Enumerable.Range(0, 50).Select(i => new S(i)));
            uni.AddRange(Enumerable.Range(0, 10).Select(i => new P(i)));
            var count = uni.ImportEnrollments(folder + @"\Enrollments.csv");
            Assert.AreEqual(10, count);
        }
    }
}
