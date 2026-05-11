using System.Globalization;

namespace MauiApp1.Extenders.Converters;

public class CategoryTransactionIconConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var category = value?.ToString()?.ToLower() ?? string.Empty;

        if (category.Contains("food") || category.Contains("alimentacao") || category.Contains("alimentação"))
            return "food_category_icon.svg";

        if (category.Contains("health") || category.Contains("saude") || category.Contains("saúde"))
            return "health_category_icon.svg";

        if (category.Contains("home") || category.Contains("casa"))
            return "home_category_icon.svg";

        if (category.Contains("education") || category.Contains("educacao") || category.Contains("educação"))
            return "education_category_icon.svg";

        if (category.Contains("leisure") || category.Contains("lazer"))
            return "leisure_category_icon.svg";

        if (category.Contains("transport") || category.Contains("transporte"))
            return "transport_category_icon.svg";

        if (category.Contains("user") || category.Contains("usuario") || category.Contains("usuário"))
            return "user_category_icon.svg";

        return "others_category_icon.svg";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}