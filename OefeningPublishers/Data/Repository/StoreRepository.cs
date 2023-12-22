using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Data.Repository
{
    public class StoreRepository
    {
        public List<Store> OphalenStoresViaStaat(string staat)
        {
            string sql = @"SELECT * FROM Publisher WHERE state like '%' @staat '%' ORDER BY name";

            var parameters = new { @staat = staat };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Store>(sql, parameters).ToList();
            }
        }
    }
}