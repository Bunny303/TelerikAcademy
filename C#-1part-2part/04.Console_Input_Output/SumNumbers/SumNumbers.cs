using System;

    class SumNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number n: ");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            int Sum = 0;
            for (i = 1; i < n+1; i++)
            {
                Console.Write("Input number {0}", i);
                int number = int.Parse(Console.ReadLine());
                Sum = Sum + number;
            }
            Console.WriteLine("The sum of numbers is {0}", Sum);
        }

       
    }

