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
            Assert.AreEqual(3, game.Ranges.Count);
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
    }
}
