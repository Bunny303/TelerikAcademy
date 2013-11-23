using System;
using System.Linq;
using System.Text;

namespace _3._4._5.ManageStudents
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public Student(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder printResult = new StringBuilder();
            printResult.AppendFormat("{0} ", this.FirstName.ToString());
            printResult.AppendFormat("{0}, ", this.LastName.ToString());
            printResult.AppendFormat("{0} years old;", this.Age.ToString());
            return printResult.ToString();
        }
    }
}
