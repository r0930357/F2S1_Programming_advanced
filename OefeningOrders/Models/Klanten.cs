using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Models
{
    public class Klanten
    {
        public int id { get; set; }
        public string bedrijf { get; set; }
        public string plaats { get; set; }
        public string postcode { get; set; }
        public string land { get; set; }
        public string telefoonnummer { get; set; }
    }
}
