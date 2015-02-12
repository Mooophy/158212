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
        [TestMethod]
        public void TestRangSet9()
        {
            var set = new Sudoku9.RangSet9();

            Assert.AreEqual(3, set.Count);
            Assert.AreEqual(true, set.Any(r => r.Begin == 6));
            Assert.AreEqual(true, set.All(r => r.Count == 3));
        }

        [TestMethod]
        public void TestCtor()
        {
            var s9 = new Library.Sudoku9();

            Assert.AreEqual(9, s9.Size);
            Assert.AreEqual(81, s9.Data.Length);
            Assert.AreEqual(3, s9.ColRangeSet.Count);
            Assert.AreEqual(3, s9.RowRangeSet.Count);
        }
    }
}
