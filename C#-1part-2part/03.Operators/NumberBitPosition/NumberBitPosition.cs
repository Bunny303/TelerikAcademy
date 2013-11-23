using System;

    class NumberBitPosition
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Please enter the bit's position: ");
            int b = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << b;
            int iAndmask = mask & i;
            int bit = iAndmask >> b;

            Console.WriteLine("The value is {0}", bit);
                   
        }
    }

