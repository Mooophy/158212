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

            Assert.AreEqual(4, s4.Size);
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

            Assert.AreEqual(4, s4.Size);
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
    }
}
