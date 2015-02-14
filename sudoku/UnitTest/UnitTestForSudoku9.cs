using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Library;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForSudoku9
    {
        int[,] _Solved = new int[9, 9]
            {
                {5,3,4,6,7,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
            };

        [TestMethod]
        public void TestRangSet9()
        {
            var set = new Library.Sudoku9.RangSet9();

            Assert.AreEqual(3, set.Count);
            Assert.AreEqual(true, set.Any(r => r.Begin == 6));
            Assert.AreEqual(true, set.All(r => r.Count == 3));
        }

        [TestMethod]
        public void TestCtor()
        {
            var s9 = new Library.Sudoku9();

            Assert.AreEqual(9, s9.Count);
            Assert.AreEqual(3, s9.ColRangeSet.Count);
            Assert.AreEqual(3, s9.RowRangeSet.Count);

            Assert.AreEqual(0, s9.Data[0,0]);
            Assert.AreEqual(0, s9.Data[5, 6]);
            Assert.AreEqual(81, s9.Data.Length);
        }

        [TestMethod]
        public void TestCtorWithData()
        {
            var s9 = new Library.Sudoku9(_Solved);

            Assert.AreEqual(9, s9.Count);
            Assert.AreEqual(3, s9.ColRangeSet.Count);
            Assert.AreEqual(3, s9.RowRangeSet.Count);

            Assert.AreEqual(5, s9.Data[0, 0]);
            Assert.AreEqual(8, s9.Data[5, 6]);
            Assert.AreEqual(81, s9.Data.Length);
        }

        [TestMethod]
        public void TestFindRowRange()
        {
            var s9 = new Library.Sudoku9(_Solved);
            var expected = new Library.Matrix.Range(3, 3);
            var actual = s9.FindRowRange(3);
            
            Assert.AreEqual(expected.Begin, actual.Begin);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void TestFindColRange()
        {
            var s9 = new Library.Sudoku9(_Solved);
            var expected = new Library.Matrix.Range(6, 3);
            var actual = s9.FindColRange(8);
            
            Assert.AreEqual(expected.Begin, actual.Begin);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void TestCheck()
        {
            var good = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var bad = new int[9] { 1, 1, 3, 4, 5, 6, 7, 8, 9 };
            var s9 = new Library.Sudoku9(_Solved);

            Assert.AreEqual(true, s9.Check(good));
            Assert.AreEqual(false, s9.Check(bad));
        }

        [TestMethod]
        public void TestCheckRow()
        {
            var s9Good = new Library.Sudoku9(_Solved);
            foreach (var row in Enumerable.Range(0, 9))
                Assert.AreEqual(true, s9Good.CheckRow(row));

            var s9Bad = new Library.Sudoku9();
            foreach (var row in Enumerable.Range(0, 9))
                Assert.AreEqual(false, s9Bad.CheckRow(row));
        }

        [TestMethod]
        public void TestCheckCol()
        {
            var s9Good = new Library.Sudoku9(_Solved);
            foreach (var col in Enumerable.Range(0, 9))
                Assert.AreEqual(true, s9Good.CheckCol(col));

            var s9Bad = new Library.Sudoku9();
            foreach (var col in Enumerable.Range(0, 9))
                Assert.AreEqual(false, s9Bad.CheckCol(col));
        }

        [TestMethod]
        public void TestCheckBox()
        {
            var allPoints =
                from r in Enumerable.Range(0, 9)
                from c in Enumerable.Range(0, 9)
                select Tuple.Create(r, c);

            var s9Good = new Library.Sudoku9(_Solved);
            Assert.AreEqual(true, s9Good.CheckBox(0, 0));
            Assert.AreEqual(true, s9Good.CheckBox(8, 0));
            var expectedAllTrue =
                allPoints
                .All(point => s9Good.CheckBox(point.Item1, point.Item2));
            Assert.AreEqual(true, expectedAllTrue);

            var s9Bad = new Library.Sudoku9();
            Assert.AreEqual(false, s9Bad.CheckBox(0, 0));
            Assert.AreEqual(false, s9Bad.CheckBox(8, 0));
            var expectedAllFalse =
                allPoints
                .All(point => s9Bad.CheckBox(point.Item1, point.Item2));
            Assert.AreEqual(false, expectedAllFalse);
        }

        [TestMethod]
        public void TestIsSolved()
        {
            var s9Good = new Library.Sudoku9(_Solved);
            Assert.AreEqual(true, s9Good.IsSolved());

            var unsolved = _Solved.Clone() as int[,];
            unsolved.SetValue(8,8,8);
            var s9Bad = new Library.Sudoku9(unsolved);
            Assert.AreEqual(false, s9Bad.IsSolved());
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
            var s9Good = new Library.Sudoku9(_Solved);
            var feedbackGood = s9Good.SetValue(5, 0, 0);
            Assert.AreEqual(9, feedbackGood.ValidRowSet.Count);
            Assert.AreEqual(9, feedbackGood.ValidColSet.Count);
            Assert.AreEqual(true, feedbackGood.IsSolved);
        }
    }
}
