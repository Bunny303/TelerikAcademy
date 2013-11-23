using System;
using System.Linq;

namespace SchoolLayout
{
    class People
    {
        // Fileds + props
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        // Constructor
        public People(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
