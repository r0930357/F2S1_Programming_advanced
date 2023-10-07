using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VakkenOefening.Data;

namespace VakkenOefening.ViewModels
{
    public partial class OverzichtVakkenViewModel : BaseViewModel
    {
        VakRepository _vakRepo;

        [ObservableProperty]
        private ObservableCollection<Vak> vakken;

        public OverzichtVakkenViewModel(VakRepository Repo, string Title)
        {
            base.Title = Title;
            _vakRepo = Repo;
        }

        [RelayCommand]
        public void ToonVakken()
        {
            Vakken = new ObservableCollection<Vak>(_vakRepo.GetVakken(false));
        }
    }
}