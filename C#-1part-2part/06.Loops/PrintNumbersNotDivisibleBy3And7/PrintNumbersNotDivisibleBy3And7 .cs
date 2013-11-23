//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

    class Program
    {
        static void Main()
        {
            //Input number N
            Console.Write("N = ");
            string consoleInput = Console.ReadLine();
            int N = int.Parse(consoleInput);

            //Loop for printing numbers
            for (int i = 1; i <= N; i++)
            {
                //Check if number is divisible by 3 and 7
                if (((i % 3) != 0) & ((i % 7) != 0))
                Console.WriteLine(i);
            }
        }
    }

