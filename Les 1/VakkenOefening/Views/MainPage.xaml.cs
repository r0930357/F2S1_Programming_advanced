namespace VakkenOefening.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OverzichtVakkenStack_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new OverzichtVakkenStack(new(new(), "OverzichtVakkenStack")));
	}
    private void OverzichtVakkenGrid_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenGrid(new(new(), "OverzichtVakkenGrid")));
    }
    private void OverzichtVakkenFlex_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenFlex(new(new(), "OverzichtVakkenFlex")));
    }
}