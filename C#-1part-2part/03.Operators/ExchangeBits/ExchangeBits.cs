//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

    class ExchangeBits
    {
        static void Main()
        {
            Console.Write("Write a number: "); //Input unsigned integer "n"
            uint n = uint.Parse(Console.ReadLine());

            Console.WriteLine("The number is: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

            uint newnumber=0;
            uint result = 0;
            
            // Get the value bit 3
            uint FirstMask = 1 << 3;
            uint nAndFirstMask = n & FirstMask;
            uint bitThree = nAndFirstMask >> 3;

            // Get the value bit 4
            uint SecondMask = 1 << 4;
            uint nAndSecondMask = n & SecondMask;
            uint bitFour = nAndSecondMask >> 4;

            // Get the value bit 5
            uint ThirdMask = 1 << 5;
            uint nAndThirdMask = n & ThirdMask;
            uint bitFive = nAndThirdMask >> 5;

            // Get the value bit 24
            uint FourthMask = 1 << 24;
            uint nAndFourthMask = n & FourthMask;
            uint bitTwentyFour = nAndFourthMask >> 24;

            // Get the value bit 25
            uint FifthMask = 1 << 25;
            uint nAndFifthMask = n & FifthMask;
            uint bitTwentyFive = nAndFifthMask >> 25;

            // Get the value bit 26
            uint SixthMask = 1 << 26;
            uint nAndSixthMask = n & SixthMask;
            uint bitTwentySix = nAndSixthMask >> 26;

            //Exchange bit 3 with bit 24 
            if (bitThree == 0)
            {
                uint mask = ~((uint)(1 << 24));
                result = n & mask;
            }
            else
            {
                uint mask = 1 << 24;    
                result = n | mask;
            }
            newnumber = result;

            //Exchange bit 4 with bit 25
            if (bitFour == 0)
            {
                uint mask = ~((uint)(1 << 25));
                result = newnumber & mask;
            }
            else
            {
                uint mask = 1 << 25;
                result = newnumber | mask;
            }
            newnumber = result;

            //Exchange bit 5 with bit 26
            if (bitFive == 0)
            {
                uint mask = ~((uint)(1 << 26));
                result = newnumber & mask;
            }
            else
            {
                uint mask = 1 << 26;
                result = newnumber | mask;
            }
            newnumber = result;

            //Exchange bit 24 with bit 3
            if (bitTwentyFour == 0)
            {
                uint mask = ~((uint)(1 << 3));
                result = newnumber & mask;
            }
            else
            {
                uint mask = 1 << 3;
                result = newnumber | mask;
            }
            newnumber = result;

            //Exchange bit 25 with bit 4
            if (bitTwentyFive == 0)
            {
                uint mask = ~((uint)(1 << 4));
                result = newnumber & mask;
            }
            else
            {
                uint mask = 1 << 4;
                result = newnumber | mask;
            }
            newnumber = result;

            //Exchange bit 26 with bit 5
            if (bitTwentySix == 0)
            {
                uint mask = ~((uint)(1 << 5));
                result = newnumber & mask;
            }
            else
            {
                uint mask = 1 << 5;
                result = newnumber | mask;
            }
            newnumber = result;

            Console.WriteLine("The modify number is: {0}", Convert.ToString(newnumber, 2).PadLeft(32, '0'));
        }
    }

