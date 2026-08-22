using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01.Interfaces
{
    internal interface IProducer<out T>
    {
        T GetItem();
    }
}