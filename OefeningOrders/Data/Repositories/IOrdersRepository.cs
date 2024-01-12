using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public interface IOrdersRepository
    {
        // Ophalen van alle orders
        public List<Orders> OphalenAlleOrders();

        // Ophalen van één order met behulp van ID
        public Orders OphalenOrdersViaId(int id);

        // Oplijsten alle bedrijven en werknemers
        public List<Orders> OphalenOrdersMetKlantenEnWerknemers();

        public List<Orderlijnen> OphalenOrdersMetProducten();
    }
}
