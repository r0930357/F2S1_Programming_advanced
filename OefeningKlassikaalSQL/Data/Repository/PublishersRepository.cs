using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Data.Repository
{
    public class PublishersRepository : BaseRepository, IPublishersRepository
    {
        public IEnumerable<Publisher> OphalenPublishers()
        {
            string sql = "SELECT * FROM Publisher ORDER BY name";
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Publisher>(sql);
            }
        }
    }
}