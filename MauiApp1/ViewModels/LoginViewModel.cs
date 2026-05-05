using CommunityToolkit.Mvvm.Input;
using MauiApp1.Views;

namespace MauiApp1.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    public LoginViewModel()
    {
        
    }

    [RelayCommand]
    public async Task OnGoToDashboard()
    {
        await Shell.Current.GoToAsync(nameof(DashboardPage));
    }
}





