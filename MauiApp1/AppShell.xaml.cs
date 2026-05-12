using MauiApp1.Views;

namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        
        Routing.RegisterRoute(nameof(NewTransactionPage), typeof(NewTransactionPage));

    }
}