using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            // Test Substring
            StringBuilder inputString = new StringBuilder();
            inputString.Append("abcdefghijk");
            Console.WriteLine(inputString.Substring(5, 5));

            //Test IEnumerable<T>
            List<int> ints = new List<int> { 1, 2, 3, 4, 5};
            Console.WriteLine(ints.Sum());
            Console.WriteLine(ints.Product());
            Console.WriteLine(ints.Min());
            Console.WriteLine(ints.Max());
            Console.WriteLine(ints.Average());
        }
    }
}
