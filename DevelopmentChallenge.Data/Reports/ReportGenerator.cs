using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Reports.Languages;

namespace DevelopmentChallenge.Data.Reports
{
    public class ReportGenerator
    {
        private readonly ILanguage _language;

        public ReportGenerator(ILanguage language)
        {
            _language = language;
        }

        public string Print(List<IShape> shapes)
        {
            if (shapes == null || shapes.Count == 0)
                return _language.GetReportTitle() + "\n" + _language.NoShapesMessage();

            var shapeCounts = new Dictionary<ShapeType, int>();
            var shapeAreas = new Dictionary<ShapeType, decimal>();
            var shapePerimeters = new Dictionary<ShapeType, decimal>();

            foreach (var shape in shapes)
            {
                var type = shape.Type;
                shapeCounts.TryGetValue(type, out int count);
                shapeCounts[type] = count + 1;

                shapeAreas.TryGetValue(type, out decimal area);
                shapeAreas[type] = area + shape.Area();

                shapePerimeters.TryGetValue(type, out decimal perimeter);
                shapePerimeters[type] = perimeter + shape.Perimeter();
            }

            var sb = new StringBuilder();
            sb.AppendLine(_language.GetReportTitle());

            decimal totalArea = 0;
            decimal totalPerimeter = 0;

            foreach (var type in shapeCounts.Keys)
            {
                int count = shapeCounts[type];
                decimal area = shapeAreas[type];
                decimal perimeter = shapePerimeters[type];

                sb.AppendLine($"{count} {_language.TranslateShapeName(type, count)} | Area {area:#.##} | Perimeter {perimeter:#.##}");

                totalArea += area;
                totalPerimeter += perimeter;
            }

            sb.AppendLine(_language.ReportTotal(shapeCounts.Values.Sum(), totalArea, totalPerimeter));

            return sb.ToString();
        }

        public List<ShapeReportItem> GetReportData(List<IShape> shapes)
        {
            var shapeCounts = new Dictionary<ShapeType, int>();
            var shapeAreas = new Dictionary<ShapeType, decimal>();
            var shapePerimeters = new Dictionary<ShapeType, decimal>();

            foreach (var shape in shapes)
            {
                var type = shape.Type;
                shapeCounts.TryGetValue(type, out int count);
                shapeCounts[type] = count + 1;

                shapeAreas.TryGetValue(type, out decimal area);
                shapeAreas[type] = area + shape.Area();

                shapePerimeters.TryGetValue(type, out decimal perimeter);
                shapePerimeters[type] = perimeter + shape.Perimeter();
            }

            var reportItems = new List<ShapeReportItem>();

            foreach (var type in shapeCounts.Keys)
            {
                reportItems.Add(new ShapeReportItem
                {
                    ShapeName = _language.TranslateShapeName(type, shapeCounts[type]),
                    Quantity = shapeCounts[type],
                    Area = shapeAreas[type],
                    Perimeter = shapePerimeters[type]
                });
            }

            return reportItems;
        }


    }
}
