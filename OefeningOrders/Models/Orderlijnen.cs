using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Models
{
    public class Orderlijnen
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int orderId { get; set; }
        public Producten product { get; set; }
        public Orders orders { get; set; }
    }
}
