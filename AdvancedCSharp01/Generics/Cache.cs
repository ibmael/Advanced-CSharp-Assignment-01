using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Generics
{
    internal class Cache<TKey, TValue>
        where TKey : notnull
    {
        #region Fields

        private readonly Dictionary<TKey, CacheItem> items = new();

        #endregion

        #region Nested Class

        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }

            public CacheItem(TValue value, DateTime expirationTime)
            {
                Value = value;
                ExpirationTime = expirationTime;
            }
        }

        #endregion

        #region Add

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            DateTime expirationTime = DateTime.Now.Add(duration);

            items[key] = new CacheItem(value, expirationTime);
        }

        #endregion

        #region Get

        public TValue? Get(TKey key)
        {
            if (!items.ContainsKey(key))
            {
                return default;
            }

            CacheItem item = items[key];

            if (DateTime.Now > item.ExpirationTime)
            {
                items.Remove(key);
                return default;
            }

            return item.Value;
        }

        #endregion

        #region Remove

        public bool Remove(TKey key)
        {
            return items.Remove(key);
        }

        #endregion

        #region Contains

        public bool Contains(TKey key)
        {
            if (!items.ContainsKey(key))
            {
                return false;
            }

            CacheItem item = items[key];

            if (DateTime.Now > item.ExpirationTime)
            {
                items.Remove(key);
                return false;
            }

            return true;
        }

        #endregion
    }
}