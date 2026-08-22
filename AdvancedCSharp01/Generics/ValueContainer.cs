using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Generics
{
    internal class ValueContainer<T> where T : struct
    {
        #region Property

        public T Value { get; set; }

        #endregion

        #region Constructor

        public ValueContainer(T value)
        {
            Value = value;
        }

        #endregion
    }
}