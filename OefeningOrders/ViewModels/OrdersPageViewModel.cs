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

        [RelayCommand]
        public void CMD_OphalenOrdersMetKlantenEnWerknemers()
        {
            IsBusy = true;
            Orders = new ObservableCollection<Orders>(_ordersRepository.OphalenOrdersMetKlantenEnWerknemers());
            IsBusy = false;
        }

        //[RelayCommand]
        //public void CMD_OphalenOrdersMetProducten()
        //{
        //    IsBusy = true;
        //    Orders = new ObservableCollection<Orders>(_ordersRepository.OphalenOrdersMetProducten());
        //    IsBusy = false;
        //}
    }
}
