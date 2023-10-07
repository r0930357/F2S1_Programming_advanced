namespace VakkenOefening.Views;

public partial class Vak1 : ContentPage
{
    public Vak1(VakViewModel vm, int idVak)
    {
        InitializeComponent();
        vm.ToonVak(idVak);
        BindingContext = vm;
    }
    public async void BtnOpslaan_Clicked(object sender, EventArgs e)
    {
        string voornaam = Voornaam.Text;
        string achternaam = Achternaam.Text;
        string locatieCampus = LocatieCampus.Text;

        bool vastLokaal = BtnVastLokaal.IsChecked;
        string lokaalnr = Lokaalnr.Text;

        DateTime datum = Datum.Date;
        double score = scoreStepper.Value;

        string message = $"Voornaam: {voornaam}Achternaam: {achternaam}Locatie: {locatieCampus} Vast Lokaal: {vastLokaal}\n" +
            $"Lokaalnummer: {lokaalnr} Datum eerste les: {datum} Score: {score}/20";

        await DisplayAlert("Info", message, "Terug aub");
    }
}