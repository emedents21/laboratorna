using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laboratorna_4;

namespace TestLab4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareResz()
        {
            var sq = new Square(5, 0, 0, 30);
            var testRez = (10);
            var rez = sq.Resize(2);
            Assert.AreEqual(testRez, rez);
        }

        [TestMethod]
        public void SquareMove()
        {
            var sq = new Square(5, 0, 0, 30);
            var testRez = (50, 50);
            var rez = sq.Move(50, 50);
            Assert.AreEqual(testRez, rez);
        }

        [TestMethod]
        public void SquareColour()
        {
            var sq = new Square(5, 0, 0, 30);
            var colour = "yellow";
            var rez = sq.ChangeColour(colour);
            Assert.AreEqual(colour, rez);
        }

        [TestMethod]
        public void EqTriangleMove()
        {
            var tri = new Square(5, 0, 0, 30);
            var rez = (50, 50);
            Assert.AreEqual(tri.Move(50, 50), rez);
        }

        [TestMethod]
        public void EqTriangleRotate()
        {
            var tri = new Square(5, 0, 0, 30);
            var rez = 90;
            Assert.AreEqual(tri.Rotate(90.0), rez);
        }
    }
}
