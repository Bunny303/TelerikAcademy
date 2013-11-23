//1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone 
//    e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
//    Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public enum Specialty
    {
        Spec1,
        Spec2,
        Spec3
    }

    public enum University
    {
        Uni1,
        Uni2,
        Uni3
    }

    public enum Faculty
    {
        Fakultet1,
        Fakultet2,
        Fakultet3
    }

    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAdress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public University UniversityName { get; set; }
        public Faculty FacultyName { get; set; }
        public Specialty SpecialtyName { get; set; }

        public Student(string firstName, string middleName, string lastName, int SSN, string permanentAddress, string mobilePhone,
            string email, University university, Faculty faculty, Specialty specialty, byte course)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAdress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.UniversityName = university;
            this.FacultyName = faculty;
            this.SpecialtyName = specialty;
            this.Course = course;
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }
        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }
        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder printStudent = new StringBuilder();
            printStudent.AppendFormat("Full name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            printStudent.AppendLine();
            printStudent.AppendLine("SSN: "+ this.SSN);
            printStudent.AppendLine("Address: "+ this.PermanentAdress);
            printStudent.AppendLine("Mobile phone: "+ this.MobilePhone);
            printStudent.AppendLine("E-mail: "+ this.Email);
            printStudent.AppendFormat("University: {0}, Faculty: {1}, Course: {2}", this.UniversityName, this.FacultyName, this.Course);
            return printStudent.ToString();
        }

        //2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        public Student Clone()
        {
            Student original = this;
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAdress,
                this.MobilePhone, this.Email, this.UniversityName, this.FacultyName, this.SpecialtyName, this.Course);

            return result;
        }
        Object ICloneable.Clone()
        {
            return this.Clone();
        }

        //3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and 
        //    by social security number (as second criteria, in increasing order).

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }
    }
}
