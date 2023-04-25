using AreaFigures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestingFigures
{
    [TestClass]
    public class TestsFigures
    {
        [TestMethod]
        public void SquareCircleOnRadiusTestMethod()
        {
            //arrange

            float radius = 4;
            var expected = 50.24f;

            //actual

            var actual = Figures.AreaCircle(radius);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareTriangleOnThreeSidesTestMethod()
        {
            //arrange
            float sideA = 3;
            float sideB = 4;
            float sideC = 5;
            var expected = 6;

            //actual

            var actual = Figures.AreaTriangle(sideA, sideB, sideC);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
