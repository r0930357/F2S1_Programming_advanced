using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public interface IKlantenRepository
    {
        // Ophalen van alle klanten
        public List<Klanten> OphalenAlleKlanten();

        // Ophalen van klant met behulp van ID
        public Klanten OphalenKlantenViaId(int id);
    }
}
