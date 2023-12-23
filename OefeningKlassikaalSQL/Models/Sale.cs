using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Models
{
    public class Sale
    {
        public int id { get; set; }
        public int storeId { get; set; }
        public int orderNumber { get; set; }
        public DateTime orderDate { get; set; }
        public int amount { get; set; }
        public int bookId { get; set; }
        public Store store { get; set; }
    }
}
