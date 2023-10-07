using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VakkenOefening.Data;
using System.Collections.ObjectModel;

namespace VakkenOefening.ViewModels
{
    public partial class VakViewModel : BaseViewModel
    {
        VakRepository _vakRepo;

        [ObservableProperty]
        private Vak vak;

        public VakViewModel(VakRepository Repo, string Title)
        {
            base.Title = Title;
            _vakRepo = Repo;
        }

        [RelayCommand]
        public void ToonVak(int idVak)
        {
            Vak = _vakRepo.GetVakken(true, idVak).First();
        }
    }
}