using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Shapes;
using System.Collections.Generic;

namespace DevelopmentChallenge.Avalonia
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public string SpanishTitle { get; } = "Reporte en Español";

        private ObservableCollection<ShapeGroupViewModel> _spanishReport = new();
        public ObservableCollection<ShapeGroupViewModel> SpanishReport
        {
            get => _spanishReport;
            set
            {
                _spanishReport = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpanishReport)));
            }
        }

        public MainWindowViewModel()
        {
            var shapes = new List<IShape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Trapezoid(3, 4, 5),
                new Rectangle(2, 6),
                new Square(2),
                new Circle(1)
            };

            SpanishReport = new ObservableCollection<ShapeGroupViewModel>(GroupShapes(shapes));
        }

        private List<ShapeGroupViewModel> GroupShapes(List<IShape> shapes)
        {
            return shapes
                .GroupBy(s => s.ShapeName)
                .Select(g => new ShapeGroupViewModel
                {
                    ShapeType = g.Key,
                    ShapeName = TranslateShapeNameToSpanish(g.Key),
                    Shapes = g.ToList()
                })
                .ToList();
        }

        private string TranslateShapeNameToSpanish(string shapeName)
        {
            return shapeName switch
            {
                "Square" => "Cuadrado",
                "Circle" => "Círculo",
                "Triangle" => "Triángulo",
                "Trapezoid" => "Trapecio",
                "Rectangle" => "Rectángulo",
                _ => shapeName
            };
        }

        public class ShapeGroupViewModel
        {
            public string ShapeName { get; set; }
            public string ShapeType { get; set; }
            public List<IShape> Shapes { get; set; }
            public int Quantity => Shapes.Count;
            public decimal TotalArea => Shapes.Sum(s => s.Area());
            public decimal TotalPerimeter => Shapes.Sum(s => s.Perimeter());
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
