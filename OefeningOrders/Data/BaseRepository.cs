using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data
{
    public abstract class BaseRepository
    {
        protected string ConnectionString { get; }

        public BaseRepository()
        {
            ConnectionString = DatabaseConnection.Connectionstring("PublishersConnectionString");
        }
    }
}
