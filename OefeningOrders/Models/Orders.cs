using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Models
{
    public class Orders
    {
        public int id { get; set; }
        public int klantId { get; set; }
        public int werknemerId { get; set; }
        public DateTime orderdatum { get; set; }
        public string verzendadres { get; set; }
        public string verzendplaats { get; set; }
        public string verzendpostcode { get; set; }
        public string verzendland { get; set; }
        public Klanten klanten { get; set; }
        public Werknemers werknemers { get; set;}
    }
}