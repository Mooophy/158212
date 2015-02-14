using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForBackEnd
    {
        [TestMethod]
        public void TestCtor()
        {
            var bg = new Library.BackEnd();
            Assert.AreEqual(3, bg.PossibleSizes.Count);
            Assert.AreEqual(81, bg.Matrix.Data.Length);
        }

        [TestMethod]
        public void TestReadFile()
        {
            var bg4 = new Library.BackEnd();
            Assert.AreEqual(16, bg4.ReadFile(@"s4.txt").Length);

            var bg6 = new Library.BackEnd();
            Assert.AreEqual(36, bg6.ReadFile(@"s6.txt").Length);

            var bg9 = new Library.BackEnd();
            Assert.AreEqual(81, bg4.ReadFile(@"s9.txt").Length);
        }

        [TestMethod]
        public void TestCtorWithData()
        {
            var bg4 = new Library.BackEnd(@"s4.txt");
            Assert.AreEqual(2, bg4.Matrix.Data[0, 0]);
            Assert.AreEqual(3, bg4.Matrix.Data[1, 1]);
            Assert.AreEqual(4, bg4.Matrix.Count);

            var bg6 = new Library.BackEnd(@"s6.txt");
            Assert.AreEqual(6, bg6.Matrix.Data[3, 3]);
            Assert.AreEqual(6, bg6.Matrix.Count);

            var bg9 = new Library.BackEnd(@"s9.txt");
            Assert.AreEqual(9, bg9.Matrix.Data[7, 8]);
            Assert.AreEqual(9, bg9.Matrix.Count);
        }


    }
}
