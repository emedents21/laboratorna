using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laba2;
using System.Diagnostics;

namespace AbstractTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testLeleka()
        {
            var calc = new Leleka(5);
            var result = 0.0025;
            var res = calc.CountEat();
            Assert.AreEqual(result, res);
        }

        [TestMethod]
        public void testVorona()
        {
            var calc = new Vorona(5);
            var result = 4;
            var res = calc.CountEat();
            Assert.AreEqual(result, res);
        }

    }
}
