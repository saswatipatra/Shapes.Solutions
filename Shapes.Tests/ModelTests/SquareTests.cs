using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void Square_GetArea_AreaOfSquare()
        {
            Rectangle newRectangle = new Rectangle(4, 4);
            Square newSquare = new Square(newRectangle);
            int result = newSquare.GetArea();
            Assert.AreEqual(result, 16);
        }
     }
}