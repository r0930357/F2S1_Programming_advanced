namespace OefeningPublishers.Views;

public partial class InstellingenPage : ContentPage
{

    InstellingenViewModel viewModel = new InstellingenViewModel();

    public InstellingenPage()
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void OnToggled(Object sender, ToggledEventArgs args)
    {
        if (!viewModel.GetoggledDoorLaden)
        {
            viewModel.ToggleTheme();
        }
        viewModel.GetoggledDoorLaden = false;
    }
}