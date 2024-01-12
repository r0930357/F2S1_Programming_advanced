using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.ViewModels
{
    public partial class WerknemersPageViewModel : BaseViewModel
    {
        private IWerknemersRepository _werknemersRepository;

        [ObservableProperty]
        private ObservableCollection<Werknemers> werknemer;

        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string achternaam;

        public WerknemersPageViewModel()
        {
            _werknemersRepository = new WerknemersRepository();
        }

        // Ophalen van alle werknemers
        [RelayCommand]
        public void CMD_OphalenAlleWerknemers()
        {
            IsBusy = true;
            Werknemer = new ObservableCollection<Werknemers>(_werknemersRepository.OphalenAlleWerknemers());
            IsBusy = false;
        }

        // Ophalen van alle werknemers op basis van de achternaam
        [RelayCommand]
        public void CMD_OphalenWerknemersViaNaam()
        {
            IsBusy = true;
            Werknemer = new ObservableCollection<Werknemers>(_werknemersRepository.OphalenWerknemersViaNaam(achternaam));
            IsBusy = false;
        }

        // Ophalen van één werknemer op basis van het id
        [RelayCommand]
        public void CMD_OphalenWerknemerViaId()
        {
            IsBusy = true;
            var werknemer = _werknemersRepository.OphalenWerknemerViaId(id);
            if (werknemer == null)
                Shell.Current.DisplayAlert("Fout", $"Werknemer met ID {id} werd niet gevonden.", "Sluiten");
            else
                Shell.Current.DisplayAlert("Werknemer gevonden", werknemer.volledigeNaam , "Sluiten");

            IsBusy = false;
        }

        [RelayCommand]
        public async Task GoToDetails(Werknemers werknemers)
        {
            try
            {
                if (werknemers == null)
                    return;

                Console.WriteLine($"Navigeren naar WerknemersDetailPage met WerknemerId: {werknemers.id}");
                await Shell.Current.GoToAsync($"{nameof(WerknemersDetailPage)}?WerknemerId={werknemers.id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout in methode GoToDetails: {ex.Message}");
            }
        }
    }
}
