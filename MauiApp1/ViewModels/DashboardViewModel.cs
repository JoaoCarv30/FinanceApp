using System.Collections.ObjectModel;
using LiveChartsCore.SkiaSharpView.Painting;
using MauiApp1.Models.Dtos;
using MauiApp1.Models.Enums;
using Microsoft.Maui.Graphics;
using SkiaSharp;

namespace MauiApp1.ViewModels;

public class DashboardViewModel : BaseViewModel
{
    public DashboardViewModel()
    {
        Data =
        [
            new("Mary", 10, GetPaint("CategoryBlue")),
            new("John", 20, GetPaint("CategoryOrange")),
            new("Alice", 30, GetPaint("CategoryPurple")),
            new("Bob", 40, GetPaint("CategoryGreen")),
            new("Charlie", 50, GetPaint("Danger"))
        ];
    }
    
    
    public ObservableCollection<TransactionDto> Transactions { get; } = new()
    {
        new TransactionDto
        {
            Title = "Lanche Do Val",
            Value = 54.90,
            Category = CategoryTransactionEnum.Food,
            Date = DateTime.Today,
            Type = TypeTransactionEnum.Expense
        },
        new TransactionDto
        {
            Title = "Salário",
            Value = 5400.00,
            Category = CategoryTransactionEnum.User,
            Date = DateTime.Today,
            Type = TypeTransactionEnum.Income
        },
        new TransactionDto
        {
            Title = "Uber",
            Value = 32.50,
            Category = CategoryTransactionEnum.Transport,
            Date = DateTime.Today.AddDays(-1),
            Type = TypeTransactionEnum.Expense
        },
        new TransactionDto
        {
            Title = "Curso",
            Value = 120.00,
            Category = CategoryTransactionEnum.Education,
            Date = DateTime.Today.AddDays(-2),
            Type = TypeTransactionEnum.Expense
        }
    };

    public PieData[] Data { get; set; }

    private static SolidColorPaint GetPaint(string resourceKey)
    {
        var mauiColor = (Color)Application.Current!.Resources[resourceKey];

        var skColor = new SKColor(
            (byte)(mauiColor.Red * 255),
            (byte)(mauiColor.Green * 255),
            (byte)(mauiColor.Blue * 255),
            (byte)(mauiColor.Alpha * 255));

        return new SolidColorPaint(skColor);
    }
}

public class PieData(string name, double value, SolidColorPaint paint)
{
    public string Name { get; set; } = name;
    public double[] Values { get; set; } = [value];
    public SolidColorPaint Paint { get; set; } = paint;
}