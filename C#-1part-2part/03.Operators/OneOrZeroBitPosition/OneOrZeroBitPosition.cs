using System;

class OneOrZeroBitPosition
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Please enter the bit's position: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << p;
            int nAndmask = mask & v;
            int bit = nAndmask >> p;
            bool ItIsTrue = true;
            bool ItIsFalse = false;
            if (bit == 1)
            {
                Console.WriteLine(ItIsTrue);
            }
            else
            {
                Console.WriteLine(ItIsFalse);
            }
        }
    }

