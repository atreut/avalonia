using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Triangle : IShape
    {
        private readonly decimal _side;

        public Triangle(decimal side) => _side = side;

        public decimal Area() => ((decimal)Math.Sqrt(3) / 4) * _side * _side;

        public decimal Perimeter() => 3 * _side;

        public ShapeType Type => ShapeType.Triangle;

        public string ShapeName => "Triangle";
    }
}
