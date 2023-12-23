using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Data.Repository
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        public Book OphalenBookViaId(int id)
        {
            string sql = "SELECT * FROM Book WHERE Id=@id";

            var parameters = new { @id = id };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Book>(sql, parameters).SingleOrDefault();
            }
        }

        public IEnumerable<Book> OphalenBooksByBookId(int bookId)
        {
            string sql = @"SELECT B.*, P.* FROM Book B INNER JOIN Publisher P ON B.publisherId = P.Id WHERE B.id LIKE '%' + @bookId + '%'";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Book, Publisher, Book>(
                    sql,
                    (book, publisher) =>
                    {
                        book.pubisers = publisher;
                        return book;
                    },
                    new { @bookId = bookId }
                );
            }
        }

    }
}
