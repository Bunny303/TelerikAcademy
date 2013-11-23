// Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

    class ExchangeRandomBits
    {
        static void Main()
        {
            Console.Write("Write a number: "); //Input unsigned integer "n", p, q, k
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("p = "); 
            byte p = byte.Parse(Console.ReadLine());
            Console.Write("q = ");
            byte q = byte.Parse(Console.ReadLine());
            Console.Write("k = ");
            byte k = byte.Parse(Console.ReadLine());

            Console.WriteLine("The number is: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

            uint newnumber = 0;
            uint result = 0;

            for (int i = p, j = q; i < p + k -1 ; i++, j++)
            {
                //get the value of first group bits
                uint firstmask = (uint)(1 << i);
                uint firstgroupbits = n & firstmask;

                //get the value of second group bits
                uint secondmask = (uint)(1 << j);
                uint secondgroupbits = n & secondmask;

                //Exchange bits of position {p, p+1, …, p+k-1) with bits of position {q, q+1, …, q+k-1}
                if (firstgroupbits == 0)
                {
                    uint mask = ~((uint)(1 << j));
                    result = n & mask;
                }
                else
                {
                    uint mask = ~((uint)(1 << j));
                    result = n | mask;
                }
                newnumber = result;

                //Exchange bits of position {q, q+1, …, q+k-1} with bits of position {p, p+1, …, p+k-1)
                if (secondgroupbits == 0)
                {
                    uint mask = ~((uint)(1 << i));
                    result = n & mask;
                }
                else
                {
                    uint mask = ~((uint)(1 << i));
                    result = n | mask;
                }
                newnumber = result;
            }

            Console.WriteLine("The new number is: {0}", Convert.ToString(newnumber, 2).PadLeft(32, '0'));
        }
    }

// Don't work :(
