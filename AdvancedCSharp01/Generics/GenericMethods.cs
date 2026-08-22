using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    internal static class GenericMethods
    {
        #region Swap Method

        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        #endregion
    }
}