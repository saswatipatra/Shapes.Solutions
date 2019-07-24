using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_GetArea_AreaOfTriangle()
        {
            Triangle newTriangle = new Triangle(5);
            double expected = 10.83;
            Assert.AreEqual(expected, newTriangle.GetArea());
        }
    }
}