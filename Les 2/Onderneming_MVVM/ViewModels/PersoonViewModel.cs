using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onderneming_MVVM.ViewModels
{
    //PersoonViewModel erft over van ObservableObject die alle mogelijkheden van INotifyPropertyChanged implementeert. We maken van de class ook een partial class.
    public partial class PersoonViewModel: ObservableObject
    {
        //ObservableProperty is een kenmerk bij het implementeren van INotifyPropertyChanged dat bij properties wordt toegevoegd zodat wijzigingen worden gemeld aan de UI. 
        [ObservableProperty]
        public string naam;      
    }
}
