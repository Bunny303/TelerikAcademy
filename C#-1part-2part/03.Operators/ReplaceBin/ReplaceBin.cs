using System;

    class ReplaceBin
    {
        static void Main()
        {
            
            Console.Write("Write a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Write a position of the bit: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Write a value of the bit: ");
            int v = int.Parse(Console.ReadLine());
            
            int mask = 1 << p;
            int maskAndn = mask & n;

            Console.Write("n={0};", n);
            Console.WriteLine("({0})", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("p={0}",p);
            Console.WriteLine("v={0}", v);

            if (maskAndn == 0)
            {
                n = n | mask;
            }
            else
            {
                n = n & ~mask;
            }

            
            Console.WriteLine("n={0},({1})", n, Convert.ToString(n, 2).PadLeft(32, '0'));
             
        }
    }

