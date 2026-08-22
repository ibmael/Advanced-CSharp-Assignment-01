using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Generics
{
    internal class ObjectFactory<T> where T : new()
    {
        #region Methods

        public T Create()
        {
            return new T();
        }

        #endregion
    }
}