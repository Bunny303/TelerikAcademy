using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanLayout
{
    class Program
    {
        static void Main()
        {
            List<Student> testStudents = new List<Student>();
            testStudents.Add(new Student("Boncho", "Kolev", 5));
            testStudents.Add(new Student("Moncho", "Motev", 4));
            testStudents.Add(new Student("Koncho", "Dolevski", 6));
            testStudents.Add(new Student("Poncho", "Toshkov", 2));
            testStudents.Add(new Student("Lala", "Shohonka", 5));
            testStudents.Add(new Student("Cecka", "Pepinka", 6));
            testStudents.Add(new Student("Mimi", "Sosos", 5));
            testStudents.Add(new Student("Pepi", "Kokokov", 6));
            testStudents.Add(new Student("Koki", "Zina", 3));
            testStudents.Add(new Student("Tonka", "traka", 2));

            // Sort students by grade
            var sortedStudents = from student in testStudents orderby student.Grade select student;

            List<Worker> testWorkers = new List<Worker>();
            testWorkers.Add(new Worker("Koncho", "Dolev", 200, 8));
            testWorkers.Add(new Worker("A", "Molev", 200, 8));
            testWorkers.Add(new Worker("B", "Tolev", 200, 5));
            testWorkers.Add(new Worker("C", "Pulev", 100, 5));
            testWorkers.Add(new Worker("D", "Mraz", 100, 8));
            testWorkers.Add(new Worker("Koncho", "Drolev", 300, 8));
            testWorkers.Add(new Worker("A", "Trolev", 200, 6));
            testWorkers.Add(new Worker("B", "Packov", 200, 2));
            testWorkers.Add(new Worker("C", "Kulev", 500, 4));
            testWorkers.Add(new Worker("D", "Draz", 100, 8));


            //Sort workers by money per hour
            var sortedWorkers = from worker in testWorkers orderby worker.MoneyPerHour() select worker;

            //Make new list from base type, add lists and sort the new one by first and last name
            List<Human> testHumans = new List<Human>();
            testHumans.AddRange(testStudents);
            testHumans.AddRange(testWorkers);
            var sortedHumans = from human in testHumans orderby human.FirstName, human.LastName select human;
        }
    }
}
