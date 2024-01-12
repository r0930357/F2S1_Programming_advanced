using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public class ProductenRepository : BaseRepository , IProductenRepository
    {
        // Ophalen van alle producten, geordend op prijs
        // De returnwaarde is een lijst van producten
        public List<Producten> OphalenAlleProducten()
        {
            string sql = "SELECT * FROM Producten ORDER BY prijs";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Producten>(sql).ToList();
            }
        }
    }
}
