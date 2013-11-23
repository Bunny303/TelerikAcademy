using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BoolExtension
{
    class BoolExtension
    {
        private const int MAX_COUNT = 6;

        public static void Main()
        {
            BoolExtension.Methods instance = new BoolExtension.Methods();
            instance.PrintBoolAsString(true);
        }

        public class Methods
        {
            public void PrintBoolAsString(bool currentBool)
            {
                string currentBoolAsString = currentBool.ToString();
                Console.WriteLine(currentBoolAsString);
            }
        }
    }
}
