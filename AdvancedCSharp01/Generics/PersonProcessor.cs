using System;
using System.Collections.Generic;
using System.Text;

using AdvancedCSharp01.Interfaces;
using AdvancedCSharp01.Models;

namespace AdvancedCSharp01.Generics
{
    internal class PersonProcessor<T>
        where T : Person, IPrintable, new()
    {
        #region Methods

        public T CreateAndPrint(string name)
        {
            T person = new T();

            person.Name = name;
            person.Print();

            return person;
        }

        #endregion
    }
}