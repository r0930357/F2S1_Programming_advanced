using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereidingsexamen.Data.Repository
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public List<Book> OphalenBoeken()
        {
            string sql = "SELECT * FROM Book ORDER BY price, releaseDate";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Book>(sql).ToList();
            }
        }

        public List<TitleAuthor> OphalenBoekenMetAuteur()
        {
            string sql = "SELECT TA.* ,B.* ,A.* FROM Book B INNER JOIN TitleAuthor TA ON B.id = TA.bookId INNER JOIN Author A ON TA.authorId = A.id";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                var debugVar = db.Query<TitleAuthor, Book, Author, TitleAuthor>(
                    sql,
                    (titleAuthor, book, author) =>
                    {
                        titleAuthor.book = book;
                        titleAuthor.author = author;
                        return titleAuthor;
                    },
                    splitOn: "Id"
                );
                return debugVar.ToList();
            }
        }
    }
}
