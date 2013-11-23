using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLayout
{
    class Program
    {
        static void Main()
        {
            // Test Discipline
            List<Discipline> testDisciplines = new List<Discipline>();
            testDisciplines.Add(new Discipline("Math", 2, 6));
            testDisciplines.Add(new Discipline("C++", 6, 2));
            testDisciplines.Add(new Discipline("C#", 8, 2));
            testDisciplines.Add(new Discipline("C", 6, 3));
            testDisciplines.Add(new Discipline("Excel", 5, 2));

            //Test Teacher
            List<Teacher> testTeachers = new List<Teacher>();
            testTeachers.Add(new Teacher("Ivan", "Ivanov", testDisciplines, ""));
            testDisciplines.RemoveAt(0); // Remove disciplnine Math and next teacher will be with different list of disciplines
            testTeachers.Add(new Teacher("Mancho","Pruskov", testDisciplines, "very good"));
            testDisciplines[2].NumberLectures = 12; //Cnange list with discipline, will have changes only in teachers after here
            testTeachers.Add(new Teacher("Gogo","Goshkov", testDisciplines, ""));

            //Test Student
            List<Student> testStudent = new List<Student>();
            testStudent.Add(new Student("haha", "brym", 34, ""));
            testStudent.Add(new Student("ha", "brym", 58, ""));
            testStudent.Add(new Student("haha", "br", 21, ""));
            testStudent.Add(new Student("hihi", "nana", 1, ""));
            testStudent.Add(new Student("momo", "drum", 5, ""));

            // Test Class
            List<Class> testClass = new List<Class>();
            testClass.Add(new Class(1, testTeachers, testStudent));
        }
    }
}
