using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Models
{
    public class TitleAuthor
    {
        public int id {  get; set; }
        public int authorId { get; set; }
        public int bookId { get; set; }
    }
}
