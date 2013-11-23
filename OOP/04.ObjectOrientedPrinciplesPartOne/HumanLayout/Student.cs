using System;
using System.Linq;

namespace HumanLayout
{
    class Student : Human
    {
        public byte Grade { get; set; }

        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
