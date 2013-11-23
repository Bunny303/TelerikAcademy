using System;
using System.Linq;

namespace AnimalLayout
{
    class Kitten : Cat
    {
        public Kitten(byte age, string name)
            : base(age, name)
        {
            this.IsMale = false;
        }
    }
}
