using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Reports.Languages
{
    public class EnglishLanguage : ILanguage
    {
        public string GetReportTitle()
        {
            return "Shapes Report";
        }

        public string TranslateShapeName(ShapeType shapeType, int quantity)
        {
            return shapeType switch
            {
                ShapeType.Square => quantity == 1 ? "Square" : "Squares",
                ShapeType.Circle => quantity == 1 ? "Circle" : "Circles",
                ShapeType.Triangle => quantity == 1 ? "Triangle" : "Triangles",
                ShapeType.Trapezoid => quantity == 1 ? "Trapezoid" : "Trapezoids",
                ShapeType.Rectangle => quantity == 1 ? "Rectangle" : "Rectangles",
                _ => "Unknown"
            };
        }

        public string NoShapesMessage()
        {
            return "No shapes found.";
        }

        public string ReportTotal(int totalShapes, decimal totalPerimeter, decimal totalArea)
        {
            return $"{totalShapes} shapes | Perimeter {totalPerimeter:#.##} | Area {totalArea:#.##}";
        }
    }
}
