using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Library;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForSudoku6
    {
        int[,] _Solved = new int[,]
        {
            {2,4,6,5,3,1},
            {5,1,3,6,2,4},
            {1,6,2,3,4,5},
            {3,5,4,2,1,6},
            {6,2,1,4,5,3},
            {4,3,5,1,6,2}
        };

        [TestMethod]
        public void TestRRangSet()
        {
            var set = new Library.Sudoku6.RRangeSet();
            Assert.AreEqual(true, set.Any(r => r.Begin == 4));
            Assert.AreEqual(true, set.All(r => r.Count == 2));
        }

        [TestMethod]
        public void TestCRangeSet()
        {
            var set = new Library.Sudoku6.CRangeSet();
            Assert.AreEqual(true, set.Any(r => r.Begin == 3));
            Assert.AreEqual(true, set.All(r => r.Count == 3));
        }

        [TestMethod]
        public void TestCtor()
        {
            var s6 = new Library.Sudoku6();

            Assert.AreEqual(6, s6.Count);
            Assert.AreEqual(2, s6.ColRangeSet.Count);
            Assert.AreEqual(3, s6.RowRangeSet.Count);

            Assert.AreEqual(0, s6.Data[0, 0]);
            Assert.AreEqual(0, s6.Data[5, 5]);
            Assert.AreEqual(36, s6.Data.Length);
        }

        [TestMethod]
        public void TestCtorWithData()
        {
            var s6 = new Library.Sudoku6(_Solved);

            Assert.AreEqual(6, s6.Count);
            Assert.AreEqual(2, s6.ColRangeSet.Count);
            Assert.AreEqual(3, s6.RowRangeSet.Count);

            Assert.AreEqual(2, s6.Data[0, 0]);
            Assert.AreEqual(1, s6.Data[1, 1]);
            Assert.AreEqual(36, s6.Data.Length);
        }

        [TestMethod]
        public void TestFindRowRange()
        {
            var s6 = new Library.Sudoku6(_Solved);
            var expected = new Library.Matrix.Range(0, 2);
            var actual = s6.FindRowRange(1);

            Assert.AreEqual(expected.Begin, actual.Begin);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void TestFindColRange()
        {
            var s6 = new Library.Sudoku6(_Solved);
            var expected = new Library.Matrix.Range(3, 3);
            var actual = s6.FindColRange(4);

            Assert.AreEqual(expected.Begin, actual.Begin);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void TestCheck()
        {
            var good = new int[6] { 1, 2, 3, 4, 5, 6 };
            var bad = new int[6] { 1, 1, 3, 4, 5, 6 };
            var s6 = new Library.Sudoku6(_Solved);

            Assert.AreEqual(true, s6.Check(good));
            Assert.AreEqual(false, s6.Check(bad));
        }

        [TestMethod]
        public void TestCheckRow()
        {
            var s6Good = new Library.Sudoku6(_Solved);
            foreach (var row in Enumerable.Range(0, 6))
                Assert.AreEqual(true, s6Good.CheckRow(row));

            var s6Bad = new Library.Sudoku6();
            foreach (var row in Enumerable.Range(0, 6))
                Assert.AreEqual(false, s6Bad.CheckRow(row));
        }

        [TestMethod]
        public void TestCheckCol()
        {
            var s6Good = new Library.Sudoku6(_Solved);
            foreach (var col in Enumerable.Range(0, 6))
                Assert.AreEqual(true, s6Good.CheckCol(col));

            var s6Bad = new Library.Sudoku6();
            foreach (var col in Enumerable.Range(0, 6))
                Assert.AreEqual(false, s6Bad.CheckCol(col));
        }

        [TestMethod]
        public void TestCheckBox()
        {
            var allPoints =
                from r in Enumerable.Range(0, 6)
                from c in Enumerable.Range(0, 6)
                select Tuple.Create(r, c);

            var s6Good = new Library.Sudoku6(_Solved);
            Assert.AreEqual(true, s6Good.CheckBox(0, 0));
            Assert.AreEqual(true, s6Good.CheckBox(3, 2));
            var expectedAllTrue =
                allPoints
                .All(point => s6Good.CheckBox(point.Item1, point.Item2));
            Assert.AreEqual(true, expectedAllTrue);

            var s6Bad = new Library.Sudoku6();
            Assert.AreEqual(false, s6Bad.CheckBox(0, 0));
            Assert.AreEqual(false, s6Bad.CheckBox(3, 4));
            var expectedAllFalse =
                allPoints
                .All(point => s6Bad.CheckBox(point.Item1, point.Item2));
            Assert.AreEqual(false, expectedAllFalse);
        }

        [TestMethod]
        public void TestIsSolved()
        {
            var s6Good = new Library.Sudoku6(_Solved);
            Assert.AreEqual(true, s6Good.IsSolved());

            var unsolved = _Solved.Clone() as int[,];
            unsolved.SetValue(5, 5, 5);
            var s6Bad = new Library.Sudoku6(unsolved);
            Assert.AreEqual(false, s6Bad.IsSolved());
        }

        [TestMethod]
        public void TestResult()
        {
            var result = new Library.Matrix.Result(true, true, false, false);

            Assert.AreEqual(true, result.VaildRow);
            Assert.AreEqual(true, result.ValidCol);
            Assert.AreEqual(false, result.ValidBox);
            Assert.AreEqual(false, result.IsSolved);
        }

        [TestMethod]
        public void TestSetValue()
        {
            var s6Good = new Library.Sudoku6(_Solved);
            var feedbackGood = s6Good.SetValue(2, 0, 0);
            Assert.AreEqual(true, feedbackGood.IsSolved);
            Assert.AreEqual(6, feedbackGood.ValidRowSet.Count);
            Assert.AreEqual(6, feedbackGood.ValidColSet.Count);
        }
    }
}
