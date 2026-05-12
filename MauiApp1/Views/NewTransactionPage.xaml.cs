using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class NewTransactionPage : ContentPage
{
    public NewTransactionPage(NewTransactionViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}