using System;
using System.Collections.Generic;
using System.Text;

using AdvancedCSharp01.Interfaces;

namespace AdvancedCSharp01.Models
{
    internal class StudentProducer : IProducer<Student>
    {
        public Student GetItem()
        {
            return new Student
            {
                Name = "Ibrahim"
            };
        }
    }
}