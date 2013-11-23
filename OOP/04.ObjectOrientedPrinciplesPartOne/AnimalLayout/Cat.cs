using System;
using System.Linq;

namespace AnimalLayout
{
    abstract class Cat:Animal, ISound
    {
        public Cat(byte age, string name)
            : base(age, name)
        { }

        public Cat(byte age, string name, bool isMale)
            : base(age, name, isMale)
        { }

        public void MakeSound()
        {
            Console.WriteLine("Mqu mqu");
        }
    }
}
