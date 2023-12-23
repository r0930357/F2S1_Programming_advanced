using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Data.Repository
{
    public interface IBookRepository
    {
        public Book OphalenBookViaId(int id);
        //public IEnumerable<Book> OphalenBooksByBookId(int bookId);
        public Book OphalenBooksByBookId(int bookId);
    }
}
