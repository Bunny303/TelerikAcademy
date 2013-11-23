//Write a program that reads a number N and calculates the sum of the first N members of 
//the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;
    class SumOfSequenceOfFibonacci
    {
        static void Main()
        {
            //Input N
            Console.Write("Please enter N: ");
            int N = int.Parse(Console.ReadLine());

            //Declare first two members of the sequence of Fibonacci and variable sum
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger sum = 0;
            BigInteger temp = 0;

            //calculate the sum of the first N members
            for (int i = 0; i < N; i++)
            {
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = secondNumber + temp;
                sum = sum + temp;
            }
            Console.WriteLine("The sum is {0} ", sum);
        }
    }
