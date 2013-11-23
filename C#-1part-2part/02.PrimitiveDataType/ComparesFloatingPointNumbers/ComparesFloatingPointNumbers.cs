//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

    class ComparesFloatingPointNumbers
    {
        static void Main()
        {
            float x = 5.000005f;
            float y = 5.000008f;
            
            bool equal = ((Math.Abs(x-y))==0);
            Console.WriteLine(equal);
        }
    }

