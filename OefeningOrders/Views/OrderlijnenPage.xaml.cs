namespace OefeningOrders.Views;

public partial class OrderlijnenPage : ContentPage
{
	public OrderlijnenPage(OrdersPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}