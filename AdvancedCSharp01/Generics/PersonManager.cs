using System;
using System.Collections.Generic;
using System.Text;

using AdvancedCSharp01.Models;

namespace AdvancedCSharp01.Generics
{
    internal class PersonManager<T> where T : Person
    {
        public void DisplayName(T person)
        {
            Console.WriteLine($"Name: {person.Name}");
        }
    }
}