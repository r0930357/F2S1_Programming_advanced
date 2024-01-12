using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public class KlantenRepository : BaseRepository, IKlantenRepository
    {
        // Ophalen van alle klanten, geordend op land
        // De returnwaarde is een lijst van klanten
        public List<Klanten> OphalenAlleKlanten()
        {
            string sql = "SELECT * FROM Klanten ORDER BY land";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Klanten>(sql).ToList();
            }
        }

        // Ophalen van één klant met behulp van ID
        // De returnwaarde is één klant, op basis van het ID
        public Klanten OphalenKlantenViaId(int id)
        {
            string sql = "SELECT * FROM Klanten WHERE Id=@id";

            var parameters = new { @id = id };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Klanten>(sql, parameters).SingleOrDefault();
            }
        }
    }
}
