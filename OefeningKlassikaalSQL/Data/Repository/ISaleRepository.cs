using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Data.Repository
{
    public interface ISaleRepository
    {
        public IEnumerable<Sale> OphalenSales();
        public Sale OphalenSalesViaId(int id);
        public IEnumerable<Sale> OphalenSalesWithStoreName();
    }
}
