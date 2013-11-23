using System;

namespace TheThirdBit
{
    class TheThirdBit
    {
        static void Main()
        {
            Console.Write("Please, enter a number:");
            int number = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1;
            mask = mask << p;
            int numberMask = number & mask;
            int bit = numberMask >> p;
            if (bit == 1)
            {
                Console.WriteLine("The third bit from given number is 1");
            }
            else
            {
                Console.WriteLine("The third bit from given number is 0");
            }
        }
    }
}
