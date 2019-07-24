using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;
namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetCircumference_CircumferenceOfCircle()
        {
            Circle newCircle = new Circle(5);
            double result = newCircle.GetCircumference();
            double expected = 31.42;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Circle_GetDiameter_DiameterOfCircle()
        {
            Circle newCircle = new Circle(5);
            int result = newCircle.GetDiameter();
            int expected = 10;
            Assert.AreEqual(expected, result);
        }
    }
}