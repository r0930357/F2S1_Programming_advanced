using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereidingsexamen.Data.Repository
{
    public interface IBookRepository
    {
        public List<Book> OphalenBoeken();
        public List<TitleAuthor> OphalenBoekenMetAuteur();
    }
}