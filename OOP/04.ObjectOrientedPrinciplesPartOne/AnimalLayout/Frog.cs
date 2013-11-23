using System;
using System.Linq;

namespace AnimalLayout
{
    class Frog : Animal,ISound
    {
        public Frog(byte age, string name, bool isMale)
            : base(age, name, isMale)
        { }

        public void MakeSound()
        {
            Console.WriteLine("Kvak kvak");
        }
    }
}
