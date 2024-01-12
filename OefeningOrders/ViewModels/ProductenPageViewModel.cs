using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.ViewModels
{
    public partial class ProductenPageViewModel : BaseViewModel
    {
        private IProductenRepository _productenRepository;

        [ObservableProperty]
        private ObservableCollection<Producten> producten;

        public ProductenPageViewModel()
        {
            _productenRepository = new ProductenRepository();
        }

        // Ophalen van alle producten
        [RelayCommand]
        public void CMD_OphalenAlleProducten()
        {
            IsBusy = true;
            Producten = new ObservableCollection<Producten>(_productenRepository.OphalenAlleProducten());
            IsBusy = false;
        }
    }
}
