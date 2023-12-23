using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public int? publisherId { get; set; }
        public decimal? price { get; set; }
        public decimal? advance { get; set; }
        public int? royalty { get; set; }
        public int? sales { get; set; }
        public string notes { get; set; }
        public DateTime releaseDate { get; set; }
        public Publisher pubisers { get; set; }
    }
}
