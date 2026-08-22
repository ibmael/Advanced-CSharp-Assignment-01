using System;
using System.Collections.Generic;
using System.Text;
using AdvancedCSharp01.Interfaces;

namespace AdvancedCSharp01.Models
{
    internal class Student : IPrintable
    {
        public string Name { get; set; } = string.Empty;

        public Student()
        {
        }

        public void Print()
        {
            Console.WriteLine($"Student: {Name}");
        }
    }
}