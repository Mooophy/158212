using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BackEnd;

namespace UnitTests
{
    [TestClass]
    public class UnitTestForSudokuNine
    {
        [TestMethod]
        public void TestCtor()
        {
            var game = new BackEnd.SudokuNine();
            Assert.AreEqual(3, game.RowRanges.Count);
            Assert.AreEqual(3, game.ColRanges.Count);
        }

        [TestMethod]
        public void TestCtorForPolymorphism()
        {
            BackEnd.Matrix mat = new BackEnd.SudokuNine();
        }

        [TestMethod]
        public void TestSetValue()
        {
            BackEnd.Matrix mat = new BackEnd.SudokuNine();
            var result = mat.SetValue(0, 0, 1);

            Assert.AreEqual(false, result.Item1);
            Assert.AreEqual(false, result.Item2);
            Assert.AreEqual(false, result.Item3);
            Assert.AreEqual(false, result.Item4);
        }

        [TestMethod]
        public void TestSetValueForValidRow()
        {
            BackEnd.Matrix mat = new BackEnd.SudokuNine();
            foreach (var num in Enumerable.Range(0, 8))
                mat.SetValue(0, num, num+1);
            var result = mat.SetValue(0, 8, 9);

            Assert.AreEqual(true, result.Item1);
        }

        [TestMethod]
        public void TestSetValueForValidCol()
        {
            BackEnd.Matrix mat = new BackEnd.SudokuNine();
            foreach (var num in Enumerable.Range(0, 8))
                mat.SetValue(num, 3, num + 1);
            var result = mat.SetValue(8, 3, 9);

            Assert.AreEqual(true, result.Item2);
        }

        [TestMethod]
        public void TestSetValueForValidRegion()
        {
            BackEnd.Matrix mat = new BackEnd.SudokuNine();
            int i = 0;
            foreach (var row in Enumerable.Range(0, 3))
                foreach (var col in Enumerable.Range(0, 3))
                    mat.SetValue(row, col, ++i);
            var result = mat.SetValue(0, 0, 1);

            Assert.AreEqual(true, result.Item3);
        }

        [TestMethod]
        public void TestSolver()
        {
            var solved = new int[9, 9]
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

            var mat = new BackEnd.SudokuNine(solved);
            var result = mat.SetValue(0, 0, 5);

            Assert.AreEqual(true, result.Item1);
            Assert.AreEqual(true, result.Item2);
            Assert.AreEqual(true, result.Item3);
            Assert.AreEqual(true, result.Item4);
        }
    }
}
