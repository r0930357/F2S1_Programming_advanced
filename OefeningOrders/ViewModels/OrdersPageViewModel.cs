using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.ViewModels
{
    public partial class OrdersPageViewModel : BaseViewModel
    {
        private IOrdersRepository _ordersRepository;

        [ObservableProperty]
        private ObservableCollection<Orders> orders;

        [ObservableProperty]
        private ObservableCollection<Orderlijnen> orderlijnen;

        [ObservableProperty]
        private int id;

        public OrdersPageViewModel()
        {
            _ordersRepository = new OrdersRepository();
        }

        [RelayCommand]
        public void CMD_OphalenAlleOrders()
        {
            IsBusy = true;
            Orders = new ObservableCollection<Orders>(_ordersRepository.OphalenAlleOrders());
            IsBusy = false;
        }

        // Ophalen van één werknemer op basis van het id
        [RelayCommand]
        public void CMD_OphalenWerknemerViaId()
        {
            IsBusy = true;
            var orders = _ordersRepository.OphalenOrdersViaId(Id);
            if (orders == null)
                Shell.Current.DisplayAlert("Fout", $"Het order met ID {Id} werd niet gevonden.", "Sluiten");
            else
                Shell.Current.DisplayAlert("Order gevonden", "" , "Sluiten");
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenOrdersMetKlantenEnWerknemers()
        {
            IsBusy = true;
            Orders = new ObservableCollection<Orders>(_ordersRepository.OphalenOrdersMetKlantenEnWerknemers());
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenOrdersMetProducten()
        {
            IsBusy = true;
            Orderlijnen = new ObservableCollection<Orderlijnen>(_ordersRepository.OphalenOrdersMetProducten());
            IsBusy = false;
        }
    }
}
