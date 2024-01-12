using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OefeningOrders.ViewModels
{
    public partial class WerknemersDetailPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        private ObservableCollection<Werknemers> werknemers;

        [ObservableProperty]
        public string id;

        private Werknemers _selectedWerknemers;

        public Werknemers SelectedWerknemers
        {
            get => _selectedWerknemers;
            set => SetProperty(ref _selectedWerknemers, value);
        }

        public override void Initialize(Dictionary<string, object> navigationData)
        {

            base.Initialize(navigationData);
            if (navigationData.ContainsKey("Werknemers"))
            {
                SelectedWerknemers = navigationData["Werknemers"] as Werknemers;
            }
        }
    }

}
