namespace OefeningKlassikaalSQL.Views;

public partial class SalesPage : ContentPage
{
	public SalesPage(SalesPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}