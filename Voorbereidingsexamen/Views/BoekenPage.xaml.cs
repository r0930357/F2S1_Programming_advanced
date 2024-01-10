namespace Voorbereidingsexamen.Views;

public partial class BoekenPage : ContentPage
{
	public BoekenPage(BoekenPageViewModel viewModel)
	{
        InitializeComponent();
        BindingContext = viewModel;
    }
}