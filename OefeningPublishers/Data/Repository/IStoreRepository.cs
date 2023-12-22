﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Data.Repository
{
    internal interface IStoreRepository
    {
        public List<Store> OphalenStoresViaStaat(string staat);
        public List<Store> OphalenStoresViaNaam(string naam);
        public List<Store> OphalenStoresViaNaamEnStaat(string naam, string staat);
        public Store OphalenStoreViaId(int id);
    }
}
