using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public class WerknemersRepository : BaseRepository, IWerknemersRepository
    {
        // Ophalen van alle werknemers
        // De returnwaarde is een lijst van werknemers
        public List<Werknemers> OphalenAlleOrders()
        {
            string sql = "SELECT * FROM Werknemers";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Werknemers>(sql).ToList();
            }
        }
    }
}
