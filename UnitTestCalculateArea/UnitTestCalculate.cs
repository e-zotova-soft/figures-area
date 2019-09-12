using System;
using CalculateArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculateArea
{
    [TestClass]
    public class UnitTestCalculate
    {
        [TestMethod]
        public void TestCalcCircleArea()
        {
            Figure circle = Circle.CreateCircle(2);
            float s = circle.GetArea();
            Assert.AreEqual(Math.Round(s, 3), 12.566);
        }
        [TestMethod]
        public void TestCalcTriangleArea()
        {
            Figure triangle = Triangle.CreateTriangle(11, 12, 13);
            float s = triangle.GetArea();
            Assert.AreEqual(Math.Round(s, 3), 61.482);
        }
        [TestMethod]
        public void TestTriangleIsRectangular()
        {
            Triangle triangle = Triangle.CreateTriangle(4,5,3);
            bool isRectangular = triangle.IsRectangular();
            Assert.IsTrue(isRectangular, 
                String.Format("Expected for '{0}': true; Actual: {1}",
                triangle.ToString(), 
                isRectangular));
        }
    }
}
