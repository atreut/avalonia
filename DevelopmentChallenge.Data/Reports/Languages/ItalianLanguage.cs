using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Reports.Languages
{
    public class ItalianLanguage : ILanguage
    {
        public string GetReportTitle()
        {
            return "Rapporto sulle forme";
        }

        public string TranslateShapeName(ShapeType shapeType, int quantity)
        {
            return shapeType switch
            {
                ShapeType.Square => quantity == 1 ? "Quadrato" : "Quadrati",
                ShapeType.Circle => quantity == 1 ? "Cerchio" : "Cerchi",
                ShapeType.Triangle => quantity == 1 ? "Triangolo" : "Triangoli",
                ShapeType.Trapezoid => quantity == 1 ? "Trapezio" : "Trapezi",
                ShapeType.Rectangle => quantity == 1 ? "Rettangolo" : "Rettangoli",
                _ => "Desconhecido"
            };
        }

        public string NoShapesMessage()
        {
            return "No shapes found.";
        }

        public string ReportTotal(int totalShapes, decimal totalPerimeter, decimal totalArea)
        {
            return $"{totalShapes} rapporto | Perimeter {totalPerimeter:#.##} | Area {totalArea:#.##}";
        }
    }
}
