using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main()
        {
            //Test clone
            Student testStudent = new Student("Brym", "Brym", "Brym", 234567, "lqlqlqlqlq", "04895749875", "lasdhk@kajs", University.Uni1, Faculty.Fakultet1, Specialty.Spec1, 4);
            Student cloneStudent = testStudent.Clone();
            Console.WriteLine("Are students equal? : {0}", testStudent.Equals(cloneStudent));

            //Test deep copy and ToStirng()
            cloneStudent.SSN = 1111111;
            Console.WriteLine(cloneStudent);


        }
    }
}
