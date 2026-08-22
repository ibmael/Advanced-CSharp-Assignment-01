using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Generics
{
    internal class ReferenceContainer<T> where T : class
    {
        #region Property

        public T Value { get; set; }

        #endregion

        #region Constructor

        public ReferenceContainer(T value)
        {
            Value = value;
        }

        #endregion
    }
}
