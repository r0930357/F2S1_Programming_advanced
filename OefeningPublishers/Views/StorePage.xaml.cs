namespace OefeningPublishers.Views;

public partial class StorePage : ContentPage
{
	public StorePage(StoreViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}