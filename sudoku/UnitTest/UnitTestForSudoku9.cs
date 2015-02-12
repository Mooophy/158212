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

            Assert.AreEqual(9, s9.Size);
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

            Assert.AreEqual(9, s9.Size);
            Assert.AreEqual(3, s9.ColRangeSet.Count);
            Assert.AreEqual(3, s9.RowRangeSet.Count);

            Assert.AreEqual(5, s9.Data[0, 0]);
            Assert.AreEqual(8, s9.Data[5, 6]);
            Assert.AreEqual(81, s9.Data.Length);
        }
    }
}
