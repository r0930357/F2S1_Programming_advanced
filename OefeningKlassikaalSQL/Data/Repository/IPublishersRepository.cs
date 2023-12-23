using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Data.Repository
{
    public interface IPublishersRepository
    {
        public IEnumerable<Publisher> OphalenPublishers();
    }
}
