using System.Globalization;
using MauiApp1.Models.Enums;

namespace MauiApp1.Extenders.Converters;

public class TransactionValueConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length < 2)
            return "R$ 0,00";

        if (values[0] is not double transactionValue)
            return "R$ 0,00";

        if (values[1] is not TypeTransactionEnum transactionType)
            return transactionValue.ToString("C", new CultureInfo("pt-BR"));

        var signal = transactionType == TypeTransactionEnum.Income ? "+" : "-";
        var absValue = Math.Abs(transactionValue);

        return $"{signal} {absValue.ToString("C", new CultureInfo("pt-BR"))}";
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}