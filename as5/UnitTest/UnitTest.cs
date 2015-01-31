﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    /// <summary>
    /// Unit test for class Student
    /// </summary>
    [TestClass]
    public class UnitTestStudent
    {
        /// <summary>
        /// Constructor
        /// </summary>
        [TestMethod]
        public void TestCtor()
        {
            Student student = new Student(0, "moophy", new DateTime(), "some street");
            Assert.AreEqual(0, student.Id);
            Assert.AreEqual("moophy", student.Name);
            Assert.AreEqual(new DateTime(), student.BirthDate);
            Assert.AreEqual("some street", student.Address);
        }
        /// <summary>
        /// ToString overloaded
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            Student student = new Student(0, "moophy", new DateTime(), "some street");
            Assert.AreEqual("0,moophy,0001/1/1 0:00:00,some street", student.ToString());
        }
    }
    /// <summary>
    /// Unit test for class Paper
    /// </summary>
    [TestClass]
    public class UnitTestPaper
    {
        /// <summary>
        /// Constructor
        /// </summary>
        [TestMethod]
        public void TestCtor()
        {
            var paper = new Lib.Paper("some paper", 0, "some one");
            Assert.AreEqual("some paper", paper.Name);
            Assert.AreEqual(0, paper.Number);
            Assert.AreEqual("some one", paper.Coordinator);
        }
        /// <summary>
        /// ToString Overloaded
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            var paper = new Lib.Paper("some paper", 0, "some one");
            Assert.AreEqual("some paper,0,some one", paper.ToString());
        }
    }
    /// <summary>
    /// Unit test for class University
    /// </summary>
    [TestClass]
    public class UnitTestUniversity
    {
        /// <summary>
        /// data files used for testing
        /// </summary>
        private readonly string _StudentsDataFile = @"Data\test_student.csv";
        private readonly string _PapersDataFile = @"Data\test_paper.csv";
        private readonly string _EnrollmentDataFile = @"Data\test_enrol.csv";
        /// <summary>
        /// Default Constructor
        /// </summary>
        [TestMethod]
        public void TestDefaultCtor()
        {
            var university = new University();
        }
        /// <summary>
        /// AddStudent
        /// </summary>
        [TestMethod]
        public void TestAddStudent()
        {
            var university = new University();
            university.Add(new Student(0, "Moophy", new DateTime(), "somewhere"));
            Assert.AreEqual(1, university.Students.Count);
            university.Add(new Student(1, "Alan", new DateTime(), "somewhere else"));
            Assert.AreEqual(2, university.Students.Count);
            university.Add(new Student(0, "Moophy", new DateTime(), "somewhere"));
            Assert.AreEqual(2, university.Students.Count);

        }
        /// <summary>
        /// AddPaper
        /// </summary>
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
        /// <summary>
        /// AddRangeStudent
        /// </summary>
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
        /// <summary>
        /// AddRangePapers
        /// </summary>
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
        /// <summary>
        /// FindPaper
        /// </summary>
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
        /// <summary>
        /// FindStudent
        /// </summary>
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
        /// <summary>
        /// Enrol
        /// </summary>
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
        /// <summary>
        /// FindEnrolledByPaper
        /// </summary>
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
        /// <summary>
        /// FindEnrolledByStudent
        /// </summary>
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
        /// <summary>
        /// AddStudentsByFile
        /// </summary>
        [TestMethod]
        public void TestAddStudentsByFile()
        {
            var university = new University();
            university.AddStudentsByFile(_StudentsDataFile);

            Assert.AreEqual(2, university.Students.Count);
            Assert.AreEqual("Moophy", university.FindStudent(12027710).Name);
        }
        /// <summary>
        /// AddPapersByFile
        /// </summary>
        [TestMethod]
        public void TestAddPapersByFile()
        {
            var university = new University();
            university.AddPapersByFile(_PapersDataFile);

            Assert.AreEqual(3, university.Papers.Count);
            Assert.AreEqual("someone else", university.FindPaper(159201).Coordinator);
        }
        /// <summary>
        /// EnrolByFile
        /// </summary>
        [TestMethod]
        public void TestEnrolByFile()
        {
            var university = new University();
            university.AddStudentsByFile(_StudentsDataFile);
            university.AddPapersByFile(_PapersDataFile);
            university.EnrolByFile(_EnrollmentDataFile);

            Assert.AreEqual(2, university.Enrollment.Count);
            Assert.AreEqual(2, university.Enrollment[university.FindPaper(159201)].Count);
            Assert.AreEqual(1, university.Enrollment[university.FindPaper(159234)].Count);
        }
        /// <summary>
        /// Export
        /// </summary>
        [TestMethod]
        public void TestExport()
        {
            var university = new University();
            university.AddStudentsByFile(_StudentsDataFile);
            university.AddPapersByFile(_PapersDataFile);
            university.EnrolByFile(_EnrollmentDataFile);

            var result = university.Export(Directory.GetCurrentDirectory());
            Assert.AreEqual(true, result);
        }
    }
}
