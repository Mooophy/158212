using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace UnitTest
{
    /// <summary>
    /// for Class Utilities
    /// </summary>
    [TestClass]
    public class UnitTestForUtilities
    {
        /// <summary>
        /// for ReadFrom
        /// </summary>
        [TestMethod]
        public void TestMethodReadFrom()
        {
            var folder = Directory.GetCurrentDirectory().ToString();
            var list = new List<string>(BackEnd.Utilities.ReadFrom(folder + @"\sonnet.txt"));
            Assert.AreEqual(15, list.Count);
        }
    }
}
