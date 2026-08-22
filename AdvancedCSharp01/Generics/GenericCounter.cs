using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Generics
{
    internal class GenericCounter<T>
    {
        #region Static Field

        public static int Count = 0;

        #endregion

        #region Constructor

        public GenericCounter()
        {
            Count++;
        }

        #endregion
    }
}