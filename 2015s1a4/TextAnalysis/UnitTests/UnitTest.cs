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
        public void TestLenDic()
        {
            var list = new List<string> { "1", "a", "22", "22", "333", "www" };
            var lens = new Library.LenDic(list);

            Assert.AreEqual(2, lens[1].Count);
            Assert.AreEqual(1, lens[2].Count);
            Assert.AreEqual(2, lens[3].Count);
        }

        [TestMethod]
        public void TestFrqDic()
        {
            var list = new List<string> { "1", "a", "22", "22", "333", "a", "a" };
            var frqs = new Library.FrqDic(list);

            Assert.AreEqual(1, frqs["1"]);
            Assert.AreEqual(3, frqs["a"]);
            Assert.AreEqual(2, frqs["22"]);
            Assert.AreEqual(1, frqs["333"]);
        }
    }
}
