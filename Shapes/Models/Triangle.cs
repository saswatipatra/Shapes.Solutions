using System;

namespace Shapes.Models
{
    public class Triangle
    {
        public double Side { get; set; }

        public Triangle(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Math.Round((Math.Sqrt(3) * Side * Side / 4), 2);
        }
    }
}