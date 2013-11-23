//Write a program that calculates for given N how many trailing zeros present at the end of the number N!

using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            //Input N
            Console.Write("Please enter N = ");
            int n = int.Parse(Console.ReadLine());
            
            BigInteger counter = 0;
            BigInteger power = 1;
            while ((n / power) > 0)
            {
                power *= 5;
                counter = counter + (n / power);
            }
            Console.WriteLine("Number of trailing zeros in {0}! is {1} zeros", n, counter);
        }
    }

