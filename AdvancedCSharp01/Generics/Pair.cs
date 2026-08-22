using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal class Pair<TKey, TValue>
    {
        #region Properties

        public TKey Key { get; set; }
        public TValue Value { get; set; }

        #endregion

        #region Constructor

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        #endregion
    }
}