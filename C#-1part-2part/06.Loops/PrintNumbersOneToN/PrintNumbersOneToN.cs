//Write a program that prints all the numbers from 1 to N.

using System;

    class PrintNumbersOneToN
    {
        static void Main()
        {
            //Input number N
            Console.Write("N = ");
            string consoleInput = Console.ReadLine();
            int N = int.Parse(consoleInput);
            int i = 1;

            //Loop for printing numbers
            while (i <= N)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }

