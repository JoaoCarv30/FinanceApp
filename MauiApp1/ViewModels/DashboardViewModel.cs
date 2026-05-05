using LiveChartsCore.SkiaSharpView.Painting;
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