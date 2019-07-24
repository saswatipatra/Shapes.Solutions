using System;

namespace Shapes.Models
{
    public class Pyramid
    {
        public Triangle Face { get; set; }

        public Pyramid(Triangle triangle)
        {
            Face = triangle;
        }

        public double GetSurfaceArea()
        {
            return Math.Round(Face.GetArea() * 4, 2);
        }
    }
}