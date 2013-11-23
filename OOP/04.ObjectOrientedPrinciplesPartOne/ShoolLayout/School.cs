using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLayout
{
    class School
    {
        // Field + property
        public int ID { get; private set; }
        public List<Class> Classes { get; set; }

        // Constructor
        public School(int id, List<Class> classes)
        {
            this.ID = id;
            this.Classes = new List<Class>();
            foreach (var c in classes)
            {
                this.AddClass(new Class(c.ID, c.Teachers, c.Students));
            }
        }

        // Methods
        public void AddClass(Class newClass)
        {
            if (Classes.Contains(newClass))
            {
                throw new ArgumentException("This class already exists!"); 
            }
            else
            {
                Classes.Add(newClass);    
            }
        }

    }
}
