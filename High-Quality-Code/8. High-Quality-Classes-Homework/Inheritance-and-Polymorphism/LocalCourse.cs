using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public LocalCourse(string name)
            : this(name, null, null, null)
        {
        }

        public LocalCourse(string name, string teacherName)
            : this(name, teacherName, null, null)
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, null)
        {
        }

        public override string ToString()
        {
            if (this.Lab != null)
            {
                string result = base.ToString() + string.Format("; Lab = {0}", this.Lab) + " }";
                return result;
            }
            else
            {
                return base.ToString() + " }";
            }
        }
    }
}
