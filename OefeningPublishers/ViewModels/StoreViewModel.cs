using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.ViewModels
{
    public partial class StoreViewModel : BaseViewModel
    {
        private IStoreRepository _storesRepository;

        [ObservableProperty]
        private ObservableCollection<Store> stores;

        [ObservableProperty]
        private string naam;

        [ObservableProperty]
        private string staat;

        [ObservableProperty]
        private string id;
        public StoreViewModel()
        {
            _storesRepository = new StoreRepository();
        }
        [RelayCommand]
        public void StoreOphalenViaNaam()
        {
            IsBusy = true;
            Stores = new ObservableCollection<Store>(_storesRepository.OphalenStoreViaNaam(Naam));
            IsBusy = false;
        }

        [RelayCommand]
        public void StoreOphalenViaStaat()
        {
            IsBusy = true;
            Stores = new ObservableCollection<Store>(_storesRepository.OphalenStoreViaStaat(Staat));
            IsBusy = false;
        }

        [RelayCommand]
        public void StoreOphalenViaNaamEnStaat()
        {
            IsBusy = true;
            Stores = new ObservableCollection<Store>(_storesRepository.OphalenStoreViaNaamEnStaat(Naam, Staat));
            IsBusy = false;
        }

        [RelayCommand]
        public void StoresOphalenViaId()
        {
            if (!int.TryParse(Id, out int id))
            {
                Shell.Current.DisplayAlert("Fout", "Geef een geldige ID.", "Sluiten");
                return;
            }
            IsBusy = true;
            var store = _storesRepository.OphalenStoreViaId(id);
            if (store == null)
                Shell.Current.DisplayAlert("Fout", $"Store met ID {id} werd niet gevonden.", "Sluiten");
            else
                Shell.Current.DisplayAlert("Store gevonden", store.name, "Sluiten");

            IsBusy = false;
        }
    }
}
