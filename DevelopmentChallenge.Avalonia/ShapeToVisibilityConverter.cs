using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace DevelopmentChallenge.Avalonia
{
    public class ShapeToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string shapeType && parameter is string targetShape)
            {
                return shapeType.Equals(targetShape, StringComparison.OrdinalIgnoreCase);
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
