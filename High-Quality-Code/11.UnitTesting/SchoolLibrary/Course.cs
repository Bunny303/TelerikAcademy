using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Course
    {
        public const byte MAX_STUDENTS = 30;

        private string name;

        public Course(string name)
        {
            this.Students = new List<Student>(MAX_STUDENTS);
            this.Name = name;
        }

        public List<Student> Students { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != null && value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
            }
        }

        public void AddStudent(Student student)
        {
            bool isStudentFound = this.FindStudent(student);

            if (isStudentFound)
            {
                throw new ArgumentException("The student has been added already!");
            }

            if (this.Students.Count < (MAX_STUDENTS-1))
            {
                this.Students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The course is full. No more students can be added!");
            }
        }

        public void RemoveStudent(Student student)
        {
            bool isStudentFound = this.FindStudent(student);

            if (!isStudentFound)
            {
                throw new ArgumentException("The student is not in this course!");
            }

            this.Students.Remove(student);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Course name {0}; ", this.Name));

            for (int i = 0; i < this.Students.Count; i++)
            {
                sb.Append(this.Students[i]);
            }

            return sb.ToString();
        }

        private bool FindStudent(Student student)
        {
            bool isFound = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueNumber == student.UniqueNumber)
                {
                    isFound = true;
                }
            }

            return isFound;
        }
    }
}
