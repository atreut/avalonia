using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Square : IShape
    {
        private readonly decimal _side;

        public Square(decimal side) => _side = side;

        public decimal Area() => _side * _side;

        public decimal Perimeter() => 4 * _side;

        public ShapeType Type => ShapeType.Square;

        public string ShapeName => "Square";
    }
}
