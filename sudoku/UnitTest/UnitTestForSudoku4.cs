using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Library;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForSudoku4
    {
        int[,] _Solved = 
        {
            {3,2,4,1},
            {4,1,2,3},
            {2,3,1,4},
            {1,4,3,2}
        };

        [TestMethod]
        public void TestRangeSet4()
        {
            var set = new Library.Sudoku4.RangeSet4();

            Assert.AreEqual(2, set.Count);
            Assert.AreEqual(true, set.Any(r => r.Begin == 2));
            Assert.AreEqual(true, set.All(r => r.Count == 2));
        }

        [TestMethod]
        public void TestCtor()
        {
            var s4 = new Library.Sudoku4();

            Assert.AreEqual(4, s4.Count);
            Assert.AreEqual(2, s4.RowRangeSet.Count);
            Assert.AreEqual(2, s4.ColRangeSet.Count);

            Assert.AreEqual(0, s4.Data[0, 0]);
            Assert.AreEqual(0, s4.Data[3, 3]);
            Assert.AreEqual(16, s4.Data.Length);
        }

        [TestMethod]
        public void TestCtorWithData()
        {
            var s4 = new Library.Sudoku4(_Solved);

            Assert.AreEqual(4, s4.Count);
            Assert.AreEqual(2, s4.RowRangeSet.Count);
            Assert.AreEqual(2, s4.ColRangeSet.Count);

            Assert.AreEqual(3, s4.Data[0, 0]);
            Assert.AreEqual(2, s4.Data[3, 3]);
            Assert.AreEqual(16, s4.Data.Length);
        }

        [TestMethod]
        public void TestFindRowRange()
        {
            var s4 = new Library.Sudoku4(_Solved);
            var expected = new Library.Matrix.Range(0, 2);
            var actual = s4.FindRowRange(1);

            Assert.AreEqual(expected.Begin, actual.Begin);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void TestFindColRange()
        {
            var s4 = new Library.Sudoku4(_Solved);
            var expected = new Library.Matrix.Range(2, 2);
            var actual = s4.FindColRange(3);

            Assert.AreEqual(expected.Begin, actual.Begin);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void TestCheck()
        {
            var good = new int[4] { 1, 2, 3, 4 };
            var bad = new int[4] { 2, 2, 3, 4 };
            var s4 = new Library.Sudoku4();

            Assert.AreEqual(true, s4.Check(good));
            Assert.AreEqual(false, s4.Check(bad));
        }

        [TestMethod]
        public void TestCheckRow()
        {
            var s4Good = new Library.Sudoku4(_Solved);
            foreach (var row in Enumerable.Range(0, 4))
                Assert.AreEqual(true, s4Good.CheckRow(row));

            var s4Bad = new Library.Sudoku9();
            foreach (var row in Enumerable.Range(0, 4))
                Assert.AreEqual(false, s4Bad.CheckRow(row));
        }

        [TestMethod]
        public void TestCheckCol()
        {
            var s4Good = new Library.Sudoku4(_Solved);
            foreach (var col in Enumerable.Range(0, 4))
                Assert.AreEqual(true, s4Good.CheckCol(col));

            var s4Bad = new Library.Sudoku4();
            foreach (var col in Enumerable.Range(0, 4))
                Assert.AreEqual(false, s4Bad.CheckCol(col));
        }

        [TestMethod]
        public void TestCheckBox()
        {
            var allPoints =
                from r in Enumerable.Range(0, 4)
                from c in Enumerable.Range(0, 4)
                select Tuple.Create(r, c);

            var s4Good = new Library.Sudoku4(_Solved);
            Assert.AreEqual(true, s4Good.CheckBox(0, 0));
            Assert.AreEqual(true, s4Good.CheckBox(3, 0));
            var expectedAllTrue =
                    allPoints
                    .All(point => s4Good.CheckBox(point.Item1, point.Item2));
            Assert.AreEqual(true, expectedAllTrue);

            var s4Bad = new Library.Sudoku4();
            Assert.AreEqual(false, s4Bad.CheckBox(0, 0));
            Assert.AreEqual(false, s4Bad.CheckBox(3, 0));
            var expectedAllFalse =
                allPoints
                .All(point => s4Bad.CheckBox(point.Item1, point.Item2));
            Assert.AreEqual(false, expectedAllFalse);
        }

        [TestMethod]
        public void TestIsSolved()
        {
            var s4Good = new Library.Sudoku4(_Solved);
            Assert.AreEqual(true, s4Good.IsSolved());

            var unsolved = _Solved.Clone() as int[,];
            unsolved.SetValue(4, 3, 3);
            var s4Bad = new Library.Sudoku4(unsolved);
            Assert.AreEqual(false, s4Bad.IsSolved());
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
            var s4Good = new Library.Sudoku4(_Solved);
            var feedback = s4Good.SetValue(3, 0, 0);
            Assert.AreEqual(true, feedback.IsSolved);
            Assert.AreEqual(4, feedback.ValidColSet.Count);
            Assert.AreEqual(4, feedback.ValidRowSet.Count);
        }
    }
}
