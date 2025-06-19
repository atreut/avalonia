using System.Collections.Generic;
using System.Linq;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.ViewModels
{
    public class ShapeGroupViewModel
    {
        public string ShapeName { get; set; }
        public string ShapeType { get; set; }
        public List<IShape> Shapes { get; set; }
        public int Quantity => Shapes.Count;
        public decimal TotalArea => Shapes.Sum(s => s.Area());
        public decimal TotalPerimeter => Shapes.Sum(s => s.Perimeter());
    }

}
