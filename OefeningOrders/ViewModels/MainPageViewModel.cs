using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            SetTheme();

            MessagingCenter.Subscribe<InstellingenViewModel>(this, "ThemeChanged", (sender) =>
            {
                SetTheme();
            });
        }

        public string AchtergrondAfbeelding { get; private set; }

        private void SetTheme()
        {
            var StartTheme = Preferences.Get("Theme", "");
            string MainDir = FileSystem.AppDataDirectory;
            var FileName = StartTheme == "Dark" ? Preferences.Get("ImageDark", "") : Preferences.Get("ImageLight", "");
            Application.Current.UserAppTheme = StartTheme == "Dark" ? AppTheme.Dark : AppTheme.Light;

            if (FileName != null)
                AchtergrondAfbeelding = Path.Combine(MainDir, FileName);
        }
    }
}
