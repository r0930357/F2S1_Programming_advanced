using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        public string achtergrondAfbeelding;
        public bool IsNotBusy => !IsBusy;

        [RelayCommand]
        public async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
