﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AdapterPattern
{
    public class HttpContextCacheStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        public void Store(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }

        public T Retrieve<T>(string key)
        {
            T itemsStored = (T)HttpContext.Current.Cache.Get(key);
            if (itemsStored == null)
            {
                itemsStored = default(T);
            }
            return itemsStored;
        }
    }
}
