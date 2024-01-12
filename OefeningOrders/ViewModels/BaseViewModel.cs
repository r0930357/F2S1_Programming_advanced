using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        public bool IsNotBusy => !IsBusy;

        [RelayCommand]
        public async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
