using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLayout
{
    abstract class Animal
    {
        public byte Age { get; protected set; }
        public string Name { get; protected set; }
        public bool IsMale { get; protected set; }

        public Animal(byte age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    
        public Animal(byte age, string name, bool isMale):this(age, name)
        {
            this.IsMale = isMale;
        }
    }
}
