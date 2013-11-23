using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLayout
{
    class Class
    {
        public int ID { get; private set; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Class(int id, List<Teacher> teachers, List<Student> students)
        {
            this.ID = id;
            this.Teachers = new List<Teacher>();
            foreach (var t in teachers)
            {
                this.AddTeacher(new Teacher(t.FirstName, t.LastName, t.Disciplines, t.CommentTeacher));
            }
            this.Students = new List<Student>();
            foreach (var s in students)
            {
                this.AddStudent(new Student(s.FirstName, s.LastName, s.ID, s.CommentStudent));
            }
        }

        //Methods
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

    }
}
