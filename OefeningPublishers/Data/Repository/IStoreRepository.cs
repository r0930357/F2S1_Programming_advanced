using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Data.Repository
{
    public interface IStoreRepository
    {
        public List<Store> OphalenStoreViaStaat(string staat);
        public List<Store> OphalenStoreViaNaam(string naam);
        public List<Store> OphalenStoreViaNaamEnStaat(string naam, string staat);
        public Store OphalenStoreViaId(int id);
    }
}
