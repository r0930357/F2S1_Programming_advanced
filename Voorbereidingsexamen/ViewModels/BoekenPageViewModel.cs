using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereidingsexamen.ViewModels
{
    public partial class BoekenPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Book> books;

        [ObservableProperty]
        private ObservableCollection<TitleAuthor> titleAuthors;

        private IBookRepository _booksRepository;

        public BoekenPageViewModel()
        {
            _booksRepository = new BookRepository();
        }

        [RelayCommand]
        public void CMD_OphalenBoeken()
        {
            IsBusy = true;
            Books = new ObservableCollection<Book>(_booksRepository.OphalenBoeken());
            IsBusy = false;
        }

        [RelayCommand]
        public void CMD_OphalenBoekenMetAuteur()
        {
            IsBusy = true;
            TitleAuthors = new ObservableCollection<TitleAuthor>(_booksRepository.OphalenBoekenMetAuteur());
            IsBusy = false;
        }
    }
}
