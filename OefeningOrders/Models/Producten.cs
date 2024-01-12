using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Models
{
    public class Producten
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string verpakking { get; set; }
        public decimal prijs { get; set; }
        public int voorraad { get; set; }
    }
}
