using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onderneming_MVVM.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        WerknemerRepository _repo;

        [ObservableProperty]
        private ObservableCollection<Werknemer> werknemers;

        public MainPageViewModel(WerknemerRepository Repo)
        {
            Title = "Werknemers";
            _repo = Repo;
        }

        [RelayCommand]
        public void ToonWerknemers()
        {
            Werknemers = new ObservableCollection<Werknemer>(_repo.GetWerknemers());
        }
    }

}
