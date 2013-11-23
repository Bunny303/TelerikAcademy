using System;
using System.Linq;

namespace AnimalLayout
{
    class Tomcat: Cat
    {
        public Tomcat (byte age, string name)
            : base(age, name)
        {
            this.IsMale = true;
        }
    }
}
