using System;

namespace Shapes.Models
{
    public class Sphere                                              
    {
        public Circle CircleThruMiddle { get; set; }

        public Sphere (Circle circle)
        {
            CircleThruMiddle = circle;
        }

        public double GetVolume()
        {
            double radius = CircleThruMiddle.Radius;
            return Math.Round((4 * Math.PI * radius*radius*radius / 3), 1);
        }

        public double GetSurfaceArea()
        {
            double radius= CircleThruMiddle.Radius;
            return Math.Round(((4) * Math.PI * radius*radius), 2);
        }
    }
}