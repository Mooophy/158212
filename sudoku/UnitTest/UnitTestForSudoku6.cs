using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TestMethod1()
        {
        }
    }
}
