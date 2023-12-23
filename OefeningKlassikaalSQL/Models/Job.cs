using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Models
{
    public class Job
    {
        public int id { get; set; }
        public string description { get; set; }
        public int minLevel { get; set; }
        public int maxLevel { get; set; }
    }
}
