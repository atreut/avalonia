using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Reports;
using DevelopmentChallenge.Data.Reports.Languages;
using DevelopmentChallenge.Data.Shapes;

class Program
{
    static void Main()
    {
        var shapes = new List<IShape>
        {
            new Square(5),
            new Circle(3),
            new Triangle(4),
            new Trapezoid(3, 4, 5),
            new Rectangle(2, 6)
        };

        var reportSpanish = new ReportGenerator(new SpanishLanguage());
        var reportEnglish = new ReportGenerator(new EnglishLanguage());
        var reportItalian = new ReportGenerator(new ItalianLanguage());

        var reporteCastellano = reportSpanish.Print(shapes);
        var reporteIngles = reportEnglish.Print(shapes);
        var reporteItaliano = reportItalian.Print(shapes);

        Console.WriteLine("Reporte en Español:\n" + reporteCastellano);
        Console.WriteLine("\nReporte en Inglés:\n" + reporteIngles);
        Console.WriteLine("\nReporte en Italiano:\n" + reporteItaliano);
    }
}
