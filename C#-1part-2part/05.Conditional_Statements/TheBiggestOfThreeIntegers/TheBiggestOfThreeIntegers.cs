//Write a program that finds the biggest of three integers using nested if statements.

using System;

    class TheBiggestOfThreeIntegers
    {
        static void Main()
        {
            //Input three integer numbers
            Console.Write("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            int c = int.Parse(Console.ReadLine());

            // 1. a >= b 
            //    a >= c --> a
            // 2. a >= b 
            //    a < c --> c
            
            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine("The biggest number is {0}", a);
                }
                else 
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }

            // 1. a < b 
            //    b >= c --> b
            // 2. a < b 
            //    b < c --> c

            else
            {
                if (b >= c)
                {
                    Console.WriteLine("The biggest number is {0}", b);
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }

        }
    }
   

