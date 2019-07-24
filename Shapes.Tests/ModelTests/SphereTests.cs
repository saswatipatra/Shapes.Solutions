using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void Sphere_GetVolume_VolumeOfSphere()
        {
            Circle newCircle = new Circle(5);
            Sphere newSphere = new Sphere(newCircle);
            double result = newSphere.GetVolume();
            double expected= 523.6;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
        {
            Circle newCircle = new Circle(5);
            Sphere newSphere = new Sphere(newCircle);
            double expected= 314.16;
            double result = newSphere.GetSurfaceArea();
            Assert.AreEqual(expected, result);
        }
    }
}