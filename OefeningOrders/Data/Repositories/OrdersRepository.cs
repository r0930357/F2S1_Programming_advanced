using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public class OrdersRepository : BaseRepository, IOrdersRepository
    {
        // Ophalen van alle orders, geordend op verzendland
        // De returnwaarde is een lijst van orders
        public List<Orders> OphalenAlleOrders()
        {
            string sql = "SELECT * FROM Orders ORDER BY verzendland";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Orders>(sql).ToList();
            }
        }

        // Ophalen van één order met behulp van ID
        // De returnwaarde is één order, op basis van het ID
        public Orders OphalenOrdersViaId(int id)
        {
            string sql = "SELECT * FROM Orders WHERE Id=@id";

            var parameters = new { @id = id };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Orders>(sql, parameters).SingleOrDefault();
            }
        }

        // Oplijsten alle bedrijven en werknemers, gekoppeld aan de werkorders
        // De returnwaarde is een lijst van orders met bedrijven en werknemers
        public List<Orders> OphalenOrdersMetKlantenEnWerknemers()
        {
            string sql = "SELECT O.*, K.*, W.* FROM Orders O INNER JOIN klanten K ON O.klantId = K.id INNER JOIN werknemers W ON O.werknemerId = W.id";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                var debugVar = db.Query<Orders, Klanten, Werknemers, Orders>(
                    sql,
                    (orders, klanten, werknemers) =>
                    {
                        orders.klanten = klanten;
                        orders.werknemers = werknemers;
                        return orders;
                    },
                    splitOn: "Id"
                );
                return debugVar.ToList();
            }
        }

        public List<Orderlijnen> OphalenOrdersMetProducten()
        {
            string sql = "SELECT OL.*, O.*, P.* FROM orderlijnen OL INNER JOIN orders O ON OL.orderId = O.id INNER JOIN producten P ON OL.productId = p.id";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                var debugVar = db.Query<Orderlijnen, Orders, Producten, Orderlijnen>(
                    sql,
                    (productlijnen, orders, producten) =>
                    {
                        productlijnen.orders = orders;
                        productlijnen.product = producten;
                        return productlijnen;
                    },
                    splitOn: "Id"
                );
                return debugVar.ToList();
            }
        }
    }
}
