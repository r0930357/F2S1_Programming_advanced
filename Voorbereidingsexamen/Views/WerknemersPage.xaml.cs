namespace Voorbereidingsexamen.Views;

public partial class WerknemersPage : ContentPage
{
	public WerknemersPage(WerknemersPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}