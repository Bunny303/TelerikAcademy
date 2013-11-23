// 6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. 
//Rewrite the same with LINQ.

using System;
using System.Linq;

namespace _6.IntDivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 3, 8, 21, 7, 35, 99, 63};

            // Lambda
            var numbers = intArray.Where(x => x % 21 == 0);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //LINQ
            var nums = 
                from number in intArray
                where number % 21 == 0
                select number;

            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }

        }
    }
}
