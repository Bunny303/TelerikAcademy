using System;

    class CompareTwoNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter a number B: ");
            int b = int.Parse(Console.ReadLine());
            
            int BiggerNumber = Math.Max(a, b);
            Console.WriteLine("The bigger number is {0}", BiggerNumber);
        }
    }

