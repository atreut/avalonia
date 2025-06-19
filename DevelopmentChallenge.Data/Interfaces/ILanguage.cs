using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Reports.Languages
{
    public interface ILanguage
    {
        string GetReportTitle();
        string TranslateShapeName(ShapeType shapeType, int quantity);
        string NoShapesMessage();
        string ReportTotal(int shapesCount, decimal totalArea, decimal totalPerimeter);
    }
}