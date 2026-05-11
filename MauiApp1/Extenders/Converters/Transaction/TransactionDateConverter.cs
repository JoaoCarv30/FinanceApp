using System.Globalization;

namespace MauiApp1.Extenders.Converters;

public class TransactionDateConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not DateTime date)
            return string.Empty;

        if (date.Date == DateTime.Today)
            return "Hoje";

        if (date.Date == DateTime.Today.AddDays(-1))
            return "Ontem";

        return date.ToString("dd/MM/yyyy");
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}