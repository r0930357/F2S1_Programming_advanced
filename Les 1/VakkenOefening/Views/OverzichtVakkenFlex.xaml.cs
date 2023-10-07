namespace VakkenOefening.Views;

public partial class OverzichtVakkenFlex : ContentPage
{
	public OverzichtVakkenFlex(OverzichtVakkenViewModel vm)
	{
		InitializeComponent();
        vm.ToonVakken();
        BindingContext = vm;
	}
    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        string idVak = (sender as ImageButton).AutomationId;

        if (!string.IsNullOrEmpty(idVak))
        {
            switch(idVak)
            {
                case "1":
                    Navigation.PushAsync(new Vak1(new(new(), "Vak1"), int.Parse(idVak)));
                break;
                case "2":
                    Navigation.PushAsync(new Vak2(new(new(), "Vak2"), int.Parse(idVak)));
                break;
                case "3":
                    Navigation.PushAsync(new Vak3(new(new(), "Vak3"), int.Parse(idVak)));
                break;
                case "4":
                    Navigation.PushAsync(new Vak4(new(new(), "Vak4"), int.Parse(idVak)));
                break;
                case "5":
                    Navigation.PushAsync(new Vak5(new(new(), "Vak5"), int.Parse(idVak)));
                break;
            }
        }
    }
}