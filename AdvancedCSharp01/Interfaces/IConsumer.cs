using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Interfaces
{
    internal interface IConsumer<in T>
    {
        void Consume(T item);
    }
}