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
        
        [ObservableProperty]
        private ObservableCollection<Book> books;

        [ObservableProperty]
        private string id;

        private ISaleRepository _salesRepository;
        private IBookRepository _booksRepository;

        public SalesPageViewModel()
        {
            _salesRepository = new SaleRepository();
            _booksRepository = new BookRepository();
        }

        [RelayCommand]
        public void CMD_AlleSalesOphalen()
        {
            IsBusy = true;
            Sales = new ObservableCollection<Sale>(_salesRepository.OphalenSales());
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenSalesViaId()
        {
            if (!int.TryParse(Id, out int id))
            {
                Shell.Current.DisplayAlert("Fout", "Geef een geldige ID.", "Sluiten");
                return;
            }
            IsBusy = true;
            var sale = _salesRepository.OphalenSalesViaId(id);
            if (sale == null)
                Shell.Current.DisplayAlert("Fout", $"Sale met ID {id} werd niet gevonden.", "Sluiten");
            else
                Shell.Current.DisplayAlert("Sale gevonden", $"Ordernummer: {sale.orderNumber}", "Sluiten");
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenSalesWithStoreName()
        {
            IsBusy = true;
            Sales = new ObservableCollection<Sale>(_salesRepository.OphalenSalesWithStoreName());
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenBooksByBookId(Sale sale)
        {
            IsBusy = true;
            Books = new ObservableCollection<Book>(_booksRepository.OphalenBooksByBookId(sale.bookId));
            IsBusy = false;
        }
    }
}
