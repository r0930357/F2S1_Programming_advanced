using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Data.Repository
{
    public class StoreRepository : BaseRepository, IStoreRepository
    {
        public List<Store> OphalenStoreViaNaam(string naam)
        {
            string sql = "SELECT * FROM Store WHERE name like '%'+ @naam +'%' ORDER BY name";

            var parameters = new { @naam = naam };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).ToList();
            }
        }
        public List<Store> OphalenStoreViaStaat(string staat)
        {
            string sql = @"SELECT * FROM Store WHERE state like '%'+ @staat +'%' ORDER BY name";

            var parameters = new { @staat = staat };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).ToList();
            }
        }

        public List<Store> OphalenStoreViaNaamEnStaat(string naam, string staat)
        {
            string sql = @"SELECT * FROM Store WHERE name like '%'+ @naam +'%' AND state like '%'+ @staat +'%' ORDER BY name";

            var parameters = new { @naam = naam, @staat = staat };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).ToList();
            }
        }
        public Store OphalenStoreViaId(int id)
        {
            string sql = "SELECT * FROM Store WHERE Id=@id";

            var parameters = new { @id = id };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).SingleOrDefault();
            }
        }
    }
}