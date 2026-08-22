using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Generics
{
    internal class BaseContainer<T>
    {
        #region Property

        public T? Value { get; set; }

        #endregion
    }
}