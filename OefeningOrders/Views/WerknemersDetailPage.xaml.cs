namespace OefeningOrders.Views;

public partial class WerknemersDetailPage : ContentPage
{
	public WerknemersDetailPage(WerknemersDetailPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}