using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Models
{
    public class Werknemers
    {
        public int id { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string functie { get; set; }
        public DateTime geboortedatum { get; set; }
        public DateTime inDienst { get; set; }
        public string avatar { get; set; }

        public string volledigeNaam => $"{voornaam} {achternaam}";

        public override string ToString()
        {
            return volledigeNaam;
        }
    }
}