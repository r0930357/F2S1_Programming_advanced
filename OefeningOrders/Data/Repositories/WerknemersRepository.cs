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
        public List<Werknemers> OphalenAlleWerknemers()
        {
            string sql = "SELECT * FROM Werknemers";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Werknemers>(sql).ToList();
            }
        }

        // Ophalen van alle werknemers op basis van de achternaam
        // De returnwaarde is een lijst van klanten met de gevraagde achternaam
        public List<Werknemers> OphalenWerknemersViaNaam(string achternaam)
        {
            string sql = "SELECT * FROM Werknemers WHERE achternaam like '%'+ @achternaam +'%' ORDER BY voornaam";

            var parameters = new { @achternaam = achternaam };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Werknemers>(sql, parameters).ToList();
            }
        }

        // Ophalen van één werknemer op basis van het id
        // De returnwaarde is één werknemer op basis van het id
        public Werknemers OphalenWerknemerViaId(int id)
        {
            string sql = "SELECT * FROM Werknemers WHERE Id=@id";

            var parameters = new { @id = id };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Werknemers>(sql, parameters).SingleOrDefault();
            }
        }
    }
}
