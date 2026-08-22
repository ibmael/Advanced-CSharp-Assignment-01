using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal class Container<T>
    {
        #region Field

        private T item;

        #endregion

        #region Methods

        public void Add(T value)
        {
            item = value;
        }

        public T Get()
        {
            return item;
        }

        #endregion
    }
}