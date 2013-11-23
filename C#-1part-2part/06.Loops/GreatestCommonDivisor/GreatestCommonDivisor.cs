//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).

using System;

    class GreatestCommonDivisor
    {
        static void Main()
        {
            //Input two integer numbers
            Console.Write("Please enter first positive integer number: ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Please enter second positive integer number: ");
            uint b = uint.Parse(Console.ReadLine());
            Console.Write("The greatest common divisor of {0} and {1} is ", a, b);

            uint gcd = 1;
            uint temp = 0;

            while (b > 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            gcd = a;

            Console.WriteLine(gcd);
        
            


        }
    }

