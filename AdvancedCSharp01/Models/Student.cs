using System;
using System.Collections.Generic;
using System.Text;
using AdvancedCSharp01.Interfaces;


namespace AdvancedCSharp01.Models
{
    internal class Student : Person, IPrintable
    {
        public Student()
        {
        }

        public void Print()
        {
            Console.WriteLine($"Student: {Name}");
        }
    }
}