using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using TextAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        #region for class Lib.Controller
        /// <summary>
        /// for BuildOccu
        /// </summary>
        [TestMethod]
        public void TestMethodBuildOccu()
        {
            var li = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var c  = new TextAnalysis.Controller();
            var occu = c.BuildOccu(li);
            Assert.AreEqual(1, occu["cc"]);
            Assert.AreEqual(2, occu["aa"]);
            Assert.AreEqual(3, occu.Count);
        }
        /// <summary>
        /// for BuildLeng
        /// </summary>
        [TestMethod]
        public void TestMethodBuildLeng()
        {
            var li = new List<string> { "aa", "bb", "aa", "cc", "bb" };
            var c = new TextAnalysis.Controller();
            var leng = c.BuildLeng(li);
            Assert.AreEqual(1, leng.Count);
            Assert.AreEqual(3, leng[2].Count);
        }
        /// <summary>
        /// for ToString
        /// </summary>
        [TestMethod]
        public void TestMethodToString()
        {
            var li = new List<string> { "aa", "bb"};
            var c  = new TextAnalysis.Controller(li);
            Assert.AreEqual("aa bb ", c.ToString());
        }
        /// <summary>
        /// for HowOfften
        /// </summary>
        [TestMethod]
        public void TestMethodHowOften()
        {
            var li = new List<string> { "aa", "bb" };
            var c  = new TextAnalysis.Controller(li);
            Assert.AreEqual(1, c.HowOften("aa"));
            Assert.AreEqual(0, c.HowOften("cc"));
        }
        /// <summary>
        /// for MostCommon
        /// </summary>
        [TestMethod]
        public void TestMethodMostCommon()
        {
            var li = new List<string>{ "aa", "bb", "aa", "cc","bb" };
            var c = new TextAnalysis.Controller(li);
            var mc = c.MostCommon();
            Assert.AreEqual(2, mc.Item1);
            Assert.AreEqual(2, mc.Item2.Count);
        }
        /// <summary>
        /// for Longest
        /// </summary>
        [TestMethod]
        public void TestMethodLongest()
        {
            var li = new List<string>{"1", "22","22","333","333","333"};
            var c = new TextAnalysis.Controller(li);
            Assert.AreEqual(3, c.Longest().Item1);
            c.Longest().Item2.ToList().ForEach(s => Assert.AreEqual("333", s));
        }
        /// <summary>
        /// for Shortest
        /// </summary>
        [TestMethod]
        public void TestMethodShortest()
        {
            var li = new List<string> { "1", "22", "22", "333", "333", "333" };
            var c = new TextAnalysis.Controller(li);
            Assert.AreEqual(1, c.Shortest().Item1);
        }
        /// <summary>
        /// for Average
        /// </summary>
        [TestMethod]
        public void TestMethodAverage()
        {
            var li = new List<string> {"22", "22", "333", "333", "333" };
            var c = new TextAnalysis.Controller(li);
            Assert.AreEqual(2, c.Average());
        }
        /// <summary>
        /// for LookupBylength
        /// </summary>
        [TestMethod]
        public void TestMethodLookupByLength()
        {
            var li = new List<string> { "22", "22", "323", "113", "123" };
            var c = new TextAnalysis.Controller(li);
            var result = c.LookupByLength(3);
            Assert.AreEqual(3, result.Count);
            result.ToList().ForEach(s => Assert.AreEqual(3, s.Length));
        }
        #endregion for class Lib.Controller

        #region for MainForm
        /// <summary>
        /// for default constructor
        /// </summary>
        [TestMethod]
        public void TestDefaultConstructor()
        {
            var form = new TextAnalysis.MainForm();
            foreach( var button in AllControls.Get(form, typeof(Button)))
                Assert.AreEqual(false, button.Enabled);
        }
        #endregion
    }
}
