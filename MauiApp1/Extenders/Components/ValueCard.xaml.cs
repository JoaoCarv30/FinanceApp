namespace MauiApp1.Extenders.Components;

public partial class ValueCard : ContentView
{
    public ValueCard()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty =
        BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(ValueCard),
            string.Empty);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(
            nameof(Value),
            typeof(string),
            typeof(ValueCard),
            string.Empty);

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public static readonly BindableProperty IsEntradaProperty =
        BindableProperty.Create(
            nameof(IsEntrada),
            typeof(bool),
            typeof(ValueCard),
            true);

    public bool IsEntrada
    {
        get => (bool)GetValue(IsEntradaProperty);
        set => SetValue(IsEntradaProperty, value);
    }
}