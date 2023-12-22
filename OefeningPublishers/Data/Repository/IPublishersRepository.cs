using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Data.Repository
{
    public interface IPublishersRepository
    {
        public IEnumerable<Publisher> OphalenPublishers();
    }
}
