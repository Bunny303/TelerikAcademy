using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse :Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, string teacherName, IList<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public OffsiteCourse(string name)
            : this(name, null, null, null)
        {
        }

        public OffsiteCourse(string name, string teacherName)
            : this(name, teacherName, null, null)
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, null)
        {
        }

        public override string ToString()
        {
            if (this.Town != null)
            {
                string result = base.ToString() + string.Format("; Town = {0}", this.Town) + " }";
                return result;
            }
            else
            {
                return base.ToString() + " }";
            }
        }
    }
}
