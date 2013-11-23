using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public School()
        {
            this.Courses = new List<Course>();
        }

        public List<Course> Courses { get; set; }

        public void AddCourse(Course course)
        {
            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            bool isCourseFound = this.FindCourse(course);
            if (!isCourseFound)
            {
                throw new ArgumentException("The course is not in the school!");
            }

            this.Courses.Remove(course);
        }

        private bool FindCourse(Course course)
        {
            bool isFound = false;
            for (int i = 0; i < this.Courses.Count; i++)
            {
                if (this.Courses[i].Name == course.Name)
                {
                    isFound = true;
                }
            }

            return isFound;
        }
    }
}
