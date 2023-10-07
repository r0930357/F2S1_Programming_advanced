using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakkenOefening.Models
{
    public partial class Vak : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string naam;

        [ObservableProperty]
        public string afbeelding;

        [ObservableProperty]
        public bool heeftVastLokaal;

        [ObservableProperty]
        public char vastLokaalBlok;

        [ObservableProperty]
        public int vastLokaalNummer;
        
        [ObservableProperty]
        public int verwachteScore;

        [ObservableProperty]
        public DateTime datumEersteLes;

        [ObservableProperty]
        public int rowNumberGrid;

        [ObservableProperty]
        public int columnNumberGrid;

        [ObservableProperty]
        public IEnumerable<Docent> docenten;

        [ObservableProperty]
        public IEnumerable<Student> studenten;

        [ObservableProperty]
        public Campus locatie;

    }
}
