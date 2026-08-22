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

        #region FindMax Method

        public static T FindMax<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }

            return second;
        }

        #endregion
    }
}