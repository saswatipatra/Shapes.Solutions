namespace Shapes.Models
{
    public class Square
    {
        public Rectangle Face { get; set; }

        public Square (Rectangle side)
        {
            Face = side;
        }

        public int GetArea()
        {
            int length = Face.Length;
            return (length * length);
        }
    }
}