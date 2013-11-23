using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    class Human
    {
        public enum Sex
        {
            Male, Female
        }

        public class Person
        {
            public Sex Sex { get; set; }

            public string FullName { get; set; }

            public int Age { get; set; }
        }

        public static Person CreatePerson(int personAge)
        {
            Human newHuman = new Human();
            newHuman.Age = personAge;
            if (personAge % 2 == 0)
            {
                newHuman.FullName = "Cool Bro";
                newHuman.Sex = Sex.Male;
            }
            else
            {
                newHuman.FullName = "Hot Chick";
                newHuman.Sex = Sex.Female;
            }

            return newHuman;
        }
    }
}
