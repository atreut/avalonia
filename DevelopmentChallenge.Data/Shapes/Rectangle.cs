using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Rectangle : IShape
    {
        private readonly decimal _width;
        private readonly decimal _height;

        public Rectangle(decimal width, decimal height)
        {
            _width = width;
            _height = height;
        }

        public decimal Area() => _width * _height;

        public decimal Perimeter() => 2 * (_width + _height);

        public ShapeType Type => ShapeType.Rectangle;

        public string ShapeName => "Rectangle";
    }
}
