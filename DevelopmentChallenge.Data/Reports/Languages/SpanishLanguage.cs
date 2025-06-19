using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Reports.Languages
{
    public class SpanishLanguage : ILanguage
    {
        public string GetReportTitle()
        {
            return "Reporte de Formas";
        }

        public string TranslateShapeName(ShapeType shapeType, int quantity)
        {
            return shapeType switch
            {
                ShapeType.Square => quantity == 1 ? "Cuadrado" : "Cuadrados",
                ShapeType.Circle => quantity == 1 ? "Círculo" : "Círculos",
                ShapeType.Triangle => quantity == 1 ? "Triángulo" : "Triángulos",
                ShapeType.Trapezoid => quantity == 1 ? "Trapecio" : "Trapecios",
                ShapeType.Rectangle => quantity == 1 ? "Rectángulo" : "Rectángulos",
                _ => "Desconocido"
            };
        }

        public string NoShapesMessage()
        {
            return "No report found.";
        }

        public string ReportTotal(int totalShapes, decimal totalPerimeter, decimal totalArea)
        {
            return $"{totalShapes} report | Perimeter {totalPerimeter:#.##} | Area {totalArea:#.##}";
        }
    }
}
