using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Trapezoid : IShape
    {
        private readonly decimal _base1;
        private readonly decimal _base2;
        private readonly decimal _height;

        public Trapezoid(decimal base1, decimal base2, decimal height)
        {
            _base1 = base1;
            _base2 = base2;
            _height = height;
        }

        public decimal Area() => ((_base1 + _base2) / 2) * _height;

        public decimal Perimeter() => _base1 + _base2 + 2 * _height;

        public ShapeType Type => ShapeType.Trapezoid;
        public string ShapeName => "Trapezoid"; 
    }
}
