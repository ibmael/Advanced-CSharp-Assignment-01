using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Interfaces
{
    internal interface IRepository<T>
    {
        void Add(T item);

        T Get(int id);
    }
}
