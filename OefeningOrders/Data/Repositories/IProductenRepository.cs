﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOrders.Data.Repositories
{
    public interface IProductenRepository
    {
        public List<Producten> OphalenAlleProducten();
    }
}
