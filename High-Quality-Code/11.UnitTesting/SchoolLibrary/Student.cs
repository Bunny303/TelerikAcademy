using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

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

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            private set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.uniqueNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The unique number have to be between 10000 and 99999");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Student {0}, ID {1}; ", this.Name, this.UniqueNumber);
        }
    }
}
