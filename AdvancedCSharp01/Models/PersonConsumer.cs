using System;
using System.Collections.Generic;
using System.Text;

using AdvancedCSharp01.Interfaces;

namespace AdvancedCSharp01.Models
{
    internal class PersonConsumer : IConsumer<Person>
    {
        public void Consume(Person item)
        {
            Console.WriteLine($"Consumed Person: {item.Name}");
        }
    }
}