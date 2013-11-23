using System;
using System.Linq;

namespace Bank
{
    public abstract class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            if (name != String.Empty)
            {
                this.Name = name;
            }
            else
            {
                throw new ArgumentNullException("Name have not to be empty");
            }
        }
    }
}
