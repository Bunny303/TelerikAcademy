using System;
using System.Linq;

namespace AnimalLayout
{
    class Dog : Animal, ISound
    {
        public Dog(byte age, string name, bool isMale)
            : base(age, name, isMale)
        { }

        public void MakeSound()
        {
            Console.WriteLine("Bau bau");
        }
    }
}
