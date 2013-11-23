using System;
using System.Linq;

namespace _3._4._5.ManageStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of students
            Student[] students = new Student[3];
            students[0] = new Student("Avan", "Beorgiev", 17);
            students[1] = new Student("Cecka", "Benkova", 31);
            students[2] = new Student("Danka", "Arankova", 20);

            // 3. Finds all students whose first name is before its last name alphabetically
            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            var definiteStudents = 
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            //Print results
            foreach (var student in definiteStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // 4. Finds the first name and last name of all students with age between 18 and 24.
            Console.WriteLine("Students with age between 18 and 24:");
            var definiteAge =
                from student in students
                where student.Age < 25 && student.Age > 17
                select student;
            //Print results
            foreach (var student in definiteAge)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();

            // 5. OrderBy - Lambda
            Console.WriteLine("Sorted by first name and last name in descending order:");
            var sortedStudents =
                students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            //Print results
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // 5. OrderBY - LINQ
            Console.WriteLine("Sorted by first name and last name in descending order:");
            var studentsSorted =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            //Print results
            foreach (var student in studentsSorted)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
