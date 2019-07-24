using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class PyramidTests
    {
        [TestMethod]
        public void Pyramid_GetSurfaceArea_AreaOfPyramid()
        {
            Triangle newTriangle = new Triangle(5);
            Pyramid newPyramid = new Pyramid(newTriangle);
            double expected = 43.32;
            Assert.AreEqual(expected, newPyramid.GetSurfaceArea());
        }
    }
}