/*  
 *  Unit test for class Lib.Controller 
 *  by Boxi Zhang 12238967 
 *  for Assignment III, 159.212 Application Software Development Summer 2014 
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace UnitTest
{
    /// <summary>
    /// Uinit test for class Lib.Controller
    /// all passed
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// testing elapsedToString
        /// passed
        /// </summary>
        [TestMethod]
        public void TestMethod_elapsedToString()
        {
            var c = new Controller();
            Assert.AreEqual("00:01", c.elapsedToString(1));
            Assert.AreEqual("01:00", c.elapsedToString(60));
            Assert.AreEqual("10:00",c.elapsedToString(600));
        }

        /// <summary>
        /// testing mapPoints
        /// passed
        /// </summary>
        [TestMethod]
        public void TestMethod_mapPoints()
        {
            var c = new Controller();
            Assert.AreEqual(5, c.mapPoints(0));
            Assert.AreEqual(2, c.mapPoints(1));
            Assert.AreEqual(3, c.mapPoints(2));
            Assert.AreEqual(3, c.mapPoints(3));
        }

        /// <summary>
        /// testing makeLog
        /// passed
        /// </summary>
        [TestMethod]
        public void TestMethod_makeLog()
        {
            var GermanyVsChile = new Controller("Germany", "Chile");
            var actual  = GermanyVsChile.makeLog(true, 0, "07:10");
            var expected = "Germany scores a Try at 07:10";
            Assert.AreEqual(expected, actual);
        }
    }
}
