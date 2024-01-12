namespace OefeningOrders.Views;

public partial class OrdersPage : ContentPage
{
	public OrdersPage(OrdersPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}