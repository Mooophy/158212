using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackEnd;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForUtilities
    {
        [TestMethod]
        public void TestMethodReadFrom()
        {
            var folder = Directory.GetCurrentDirectory().ToString();
            var list = new List<string>(BackEnd.Utilities.ReadFrom(folder + @"\sonnet.txt"));
            Assert.AreEqual(15, list.Count);
        }
    }
}
