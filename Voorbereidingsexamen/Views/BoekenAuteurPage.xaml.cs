namespace Voorbereidingsexamen.Views;

public partial class BoekenAuteurPage : ContentPage
{
	public BoekenAuteurPage(BoekenPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}