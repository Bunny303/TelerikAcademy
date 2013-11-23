//Write a program that finds the greatest of given 5 variables.

using System;

    class TheBiggestOfFiveVariables
    {
        static void Main()
        {
            //Input five integer numbers
            Console.Write("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter fifth number:");
            int e = int.Parse(Console.ReadLine());

            //1. a>=b, a>=c, a>=d, a>=e --> a
            //2. b>=a, b>=c, b>=d, b>=e --> b
            //3. c>=a, c>=b, c>=d, c>=e --> c
            //4. d>=a, b>=b, d>=c, d>=e --> d
            //5. e>=a, e>=b, e>=c, e>=d --> e

            if ((a>=b)&&(a>=c)&&(a>=d)&&(a>=e))
            {
                Console.WriteLine("The greatest number is {0}: ", a);
            }
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                Console.WriteLine("The greatest number is {0}: ", b);
            }
            else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("The greatest number is {0}: ", c);
            }
            else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("The greatest number is {0}: ", d);
            }
            else
            {
                Console.WriteLine("The greatest number is {0}: ", e);
            }
        }
    }

