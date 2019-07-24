using System;

namespace Shapes.Models
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetCircumference()
        {
            return Math.Round((2 * Math.PI * Radius), 2);
        }

        public int GetDiameter()
        {
            return (int)Radius * 2;
        }
    }
}