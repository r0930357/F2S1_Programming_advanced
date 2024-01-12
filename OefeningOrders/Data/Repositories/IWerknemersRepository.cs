﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public interface IWerknemersRepository
    {
        public List<Werknemers> OphalenAlleWerknemers();

        public List<Werknemers> OphalenWerknemersViaNaam(string achternaam);

        public Werknemers OphalenWerknemerViaId(int id);
    }
}
