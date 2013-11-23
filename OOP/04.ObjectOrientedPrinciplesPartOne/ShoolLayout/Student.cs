using System;
using System.Linq;

namespace SchoolLayout
{
    class Student : People
    {
        // Fields + props
        public string CommentStudent { get; set; }
        public int ID { get; private set; }

        // Inheritance constructor
        public Student(string firstName, string lastName, int id, string comment)
            : base(firstName, lastName)
        {
            this.ID = id;
            this.CommentStudent = comment;
        }
    }
}
