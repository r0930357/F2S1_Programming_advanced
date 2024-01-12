namespace OefeningOrders.Views;

public partial class ProductenPage : ContentPage
{
	public ProductenPage(ProductenPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}