using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    [TestClass]//for Student
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

    [TestClass]//for Paper
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

    [TestClass]//for University
    public class UnitTestUniversity
    {
        [TestMethod]
        public void TestDefaultCtor()
        {
            var university = new University();
        }

        [TestMethod]
        public void TestAddStudent()
        {
            var university = new University();
            university.Add(new Student(0, "Moophy", new DateTime(), "somewhere"));
            Assert.AreEqual(1, university.Students.Count);
            university.Add(new Student(1, "Alan", new DateTime(), "somewhere else"));
            Assert.AreEqual(2, university.Students.Count);
        }

        [TestMethod]
        public void TestAddPaper()
        {
            var university = new University();
            Assert.AreEqual(0, university.Papers.Count);
            university.Add(new Paper("App Dev", 158212, "someone"));
            Assert.AreEqual(1, university.Papers.Count);
            university.Add(new Paper("Algorithms", 159201, "someone else"));
            Assert.AreEqual(2, university.Papers.Count);
        }

        [TestMethod]
        public void TestAddRangeStudent()
        {
            var university = new University();
            Assert.AreEqual(0, university.Students.Count);
            university.AddRange(new List<Student>{
                new Student(0, "Moophy", new DateTime(), "somewhere"),
                new Student(1, "Alan", new DateTime(), "somewhere else")
            });
            Assert.AreEqual(2, university.Students.Count);
        }

        [TestMethod]
        public void TestAddRangePapers()
        {
            var university = new University();
            Assert.AreEqual(0, university.Papers.Count);
            university.AddRange(new List<Paper>{
                new Paper("App Dev", 158212, "someone"),
                new Paper("Algorithms", 159201, "someone else"),
                new Paper("some paper", 12345678, "someone else again")
            });
            Assert.AreEqual(3, university.Papers.Count);
        }

        [TestMethod]
        public void TestFindPaper()
        {
            var university = new University();
            Assert.AreEqual(0, university.Papers.Count);
            university.AddRange(new List<Paper>{
                new Paper("App Dev", 158212, "someone"),
                new Paper("Algorithms", 159201, "someone else"),
                new Paper("some paper", 12345678, "someone else again")
            });

            Assert.AreEqual("App Dev", university.FindPaper(158212).Name);
            Assert.AreEqual("someone", university.FindPaper(158212).Coordinator);
            Assert.AreEqual("Algorithms", university.FindPaper(159201).Name);
        }

        [TestMethod]
        public void TestFindStudent()
        {
            var university = new University();
            Assert.AreEqual(0, university.Students.Count);
            university.AddRange(new List<Student>{
                new Student(12027710, "Moophy", new DateTime(), "somewhere"),
                new Student(12345678, "Alan", new DateTime(), "somewhere else")
            });

            Assert.AreEqual("Moophy", university.FindStudent(12027710).Name);
            Assert.AreEqual("Alan", university.FindStudent(12345678).Name);
        }

        [TestMethod]
        public void TestEnrol()
        {
            var university = new University();
            university.AddRange(new List<Student>{
                new Student(12027710, "Moophy", new DateTime(), "somewhere"),
                new Student(13333333, "Alan", new DateTime(), "somewhere else")
            });
            university.AddRange(new List<Paper>{
                new Paper("App Dev", 158212, "someone"),
                new Paper("Algorithms", 159201, "someone else"),
                new Paper("some paper", 12345678, "someone else again")
            });

            var appDev = university.FindPaper(158212);
            Assert.AreEqual(true, university.Enrol(158212, 12027710));
            Assert.AreEqual(1, university.Enrollment[appDev].Count);
            Assert.AreEqual(true, university.Enrol(158212, 13333333));
            Assert.AreEqual(1, university.Enrollment.Count);
            Assert.AreEqual(2, university.Enrollment[appDev].Count);
        }

        [TestMethod]
        public void TestFindEnrolledByPaper()
        {
            var university = new University();
            university.AddRange(new List<Student>{
                new Student(12027710, "Moophy", new DateTime(), "somewhere"),
                new Student(13333333, "Alan", new DateTime(), "somewhere else")
            });
            university.AddRange(new List<Paper>{
                new Paper("App Dev", 158212, "someone"),
                new Paper("Algorithms", 159201, "someone else"),
                new Paper("some paper", 12345678, "someone else again")
            });

            Assert.AreEqual(true, university.Enrol(158212, 12027710));
            Assert.AreEqual(true, university.Enrol(158212, 13333333));

            Assert.AreEqual(1, university.Enrollment.Count);
            Assert.AreEqual(2, university.FindEnrolledByPaper(158212).Count);
        }

        [TestMethod]
        public void TestFindEnrolledByStudent()
        {
            var university = new University();
            university.AddRange(new List<Student>{
                new Student(12027710, "Moophy", new DateTime(), "somewhere"),
                new Student(13333333, "Alan", new DateTime(), "somewhere else")
            });
            university.AddRange(new List<Paper>{
                new Paper("App Dev", 158212, "someone"),
                new Paper("Algorithms", 159201, "someone else"),
                new Paper("some paper", 12345678, "someone else again")
            });

            Assert.AreEqual(true, university.Enrol(158212, 12027710));
            Assert.AreEqual(true, university.Enrol(158212, 13333333));
            Assert.AreEqual(true, university.Enrol(159201, 13333333));

            Assert.AreEqual(1, university.FindEnrolledByStudent(12027710).Count);
            Assert.AreEqual(2, university.FindEnrolledByStudent(13333333).Count);
        }

        [TestMethod]
        public void TestAddStudentsByFile()
        {
            var university = new University();
            university.AddStudentsByFile(@"d:\test.csv");

            Assert.AreEqual(1, university.Students.Count);
            Assert.AreEqual("Moophy", university.FindStudent(12027710).Name);
        }
    }
}
