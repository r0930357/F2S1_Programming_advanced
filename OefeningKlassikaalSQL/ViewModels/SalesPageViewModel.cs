using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.ViewModels
{
    public partial class SalesPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Sale> sales;

        private ISaleRepository _salesRepository;

        public SalesPageViewModel()
        {
            _salesRepository = new SaleRepository();
        }

        [RelayCommand]
        public void CMD_OphalenSales()
        {
            IsBusy = true;
            Sales = new ObservableCollection<Sale>(_salesRepository.OphalenSales());
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenSalesViaId()
        {
            if (!int.TryParse(id, out int Id))
            {
                Shell.Current.DisplayAlert("Fout", "Geef een geldige ID.", "Sluiten");
                return;
            }
            IsBusy = true;
            var sale = _salesRepository.OphalenSalesViaId(Id);
            if (sale == null)
                Shell.Current.DisplayAlert("Fout", $"Sale met ID {Id} werd niet gevonden.", "Sluiten");
            else
                Shell.Current.DisplayAlert("Sale gevonden", sale.id.ToString(), "Sluiten");
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenSalesWithStoreName()
        {
            IsBusy = true;
            Sales = new ObservableCollection<Sale>(_salesRepository.OphalenSalesWithStoreName());
            IsBusy = false;
        }
    }
}
