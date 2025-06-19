using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Reports;
using DevelopmentChallenge.Data.Reports.Languages;
using DevelopmentChallenge.Data.Shapes;
using System.Collections.Generic;
using Xunit;

namespace DevelopmentChallenge.Data.Tests
{
    public class ReportGeneratorTests
    {
        [Fact]
        public void Report_EmptyList_Spanish()
        {
            var report = new ReportGenerator(new SpanishLanguage()).Print(new List<IShape>());
            Assert.Contains("Lista vacía de formas", report);
        }

        [Fact]
        public void Report_WithSquare_English()
        {
            var shapes = new List<IShape> { new Square(5) };
            var report = new ReportGenerator(new EnglishLanguage()).Print(shapes);
            Assert.Contains("1 Square", report);
        }

        [Fact]
        public void Report_WithMultipleShapes_Italian()
        {
            var shapes = new List<IShape> {
                new Square(3),
                new Circle(4),
                new Triangle(5),
                new Trapezoid(4, 6, 3),
                new Rectangle(2, 7)
            };

            var report = new ReportGenerator(new ItalianLanguage()).Print(shapes);
            Assert.Contains("Quadrato", report);
            Assert.Contains("Cerchio", report);
            Assert.Contains("Triangolo", report);
            Assert.Contains("Trapezio", report);
            Assert.Contains("Rettangolo", report);
        }
    }
}
