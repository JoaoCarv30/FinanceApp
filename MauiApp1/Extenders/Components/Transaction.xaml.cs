using MauiApp1.Models.Dtos;

namespace MauiApp1.Extenders.Components;

public partial class Transaction : ContentView
{
	public Transaction()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty TransactionDataProperty =
		BindableProperty.Create(
			nameof(TransactionData),
			typeof(TransactionDto),
			typeof(Transaction),
			default(TransactionDto));

	public TransactionDto TransactionData
	{
		get => (TransactionDto)GetValue(TransactionDataProperty);
		set => SetValue(TransactionDataProperty, value);
	}
}