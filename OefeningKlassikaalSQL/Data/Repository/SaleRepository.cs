using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Data.Repository
{
    public class SaleRepository : BaseRepository, ISaleRepository
    {
        public IEnumerable<Sale> OphalenSales()
        {
            string sql = "SELECT * FROM Sale";
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Sale>(sql);
            }
        }

        public Sale OphalenSalesViaId(int id)
        {
            string sql = "SELECT * FROM Sale WHERE Id=@id";

            var parameters = new { @id = id };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Sale>(sql, parameters).SingleOrDefault();
            }
        }

        public IEnumerable<Sale> OphalenSalesWithStoreName()
        {
            string sql = @"SELECT Sa.*, St.* FROM Sale Sa INNER JOIN Store St ON Sa.storeId = St.id";
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                var debugVar = db.Query<Sale, Store, Sale>(
                    sql,
                    (sale, store) =>
                    {
                        sale.store = store;
                        return sale;
                    },
                    splitOn: "id"
                );
                return debugVar;
            }
        }
    }
}
