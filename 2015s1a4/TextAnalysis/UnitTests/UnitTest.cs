using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Library;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMakeLengthsDic()
        {
            var seq = new List<string> { "a", "b", "c", "a", "c", "zzz", "zzz" };
            var dic = Library.Functions.MakeLengthsDic(seq);

            Assert.AreEqual(2, dic["a"]);
            Assert.AreEqual(1, dic["b"]);
            Assert.AreEqual(2, dic["zzz"]);
            Assert.AreEqual(4, dic.Count);
        }
    }
}
