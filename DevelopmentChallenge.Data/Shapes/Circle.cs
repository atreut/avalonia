using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Circle : IShape
    {
        private readonly decimal _diameter;

        public Circle(decimal diameter)
        {
            _diameter = diameter;
        }

        public decimal Area()
        {
            var radius = _diameter / 2;
            return (decimal)Math.PI * radius * radius;
        }

        public decimal Perimeter()
        {
            return (decimal)Math.PI * _diameter;
        }

        public ShapeType Type => ShapeType.Circle;

        public string ShapeName => "Circle";
    }
}
