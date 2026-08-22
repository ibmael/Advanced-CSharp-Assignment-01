using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Generics
{
    internal class AdvancedContainer<T> : BaseContainer<T>
    {
        #region Methods

        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
        }

        #endregion
    }
}