namespace MauiApp1.Extenders.Components;

public partial class ChartLegendItem : ContentView
{
    public ChartLegendItem()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(ChartLegendItem),
            string.Empty);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty PercentProperty =
        BindableProperty.Create(
            nameof(Percent),
            typeof(string),
            typeof(ChartLegendItem),
            string.Empty);

    public string Percent
    {
        get => (string)GetValue(PercentProperty);
        set => SetValue(PercentProperty, value);
    }

    public static readonly BindableProperty ColorProperty =
        BindableProperty.Create(
            nameof(Color),
            typeof(Color),
            typeof(ChartLegendItem),
            Colors.White);

    public Color Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }
}