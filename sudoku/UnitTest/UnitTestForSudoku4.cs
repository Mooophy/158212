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
    }
}
