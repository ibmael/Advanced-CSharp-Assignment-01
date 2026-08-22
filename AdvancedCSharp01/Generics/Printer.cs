using System;
using System.Collections.Generic;
using System.Text;

using AdvancedCSharp01.Interfaces;

namespace AdvancedCSharp01.Generics
{
    internal class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
}