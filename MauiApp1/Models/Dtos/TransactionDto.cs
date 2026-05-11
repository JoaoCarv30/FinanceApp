using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Models.Enums;

namespace MauiApp1.Models.Dtos;

public partial  class TransactionDto : ObservableObject
{
     [ObservableProperty] private string title;
     [ObservableProperty] private double value;
     [ObservableProperty] private CategoryTransactionEnum category;
     [ObservableProperty] private DateTime date;
     [ObservableProperty] private TypeTransactionEnum type;
}