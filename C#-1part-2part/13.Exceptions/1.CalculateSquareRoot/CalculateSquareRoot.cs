// 1. Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;

class CalculateSquareRoot
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        
        try
        {
            int n = int.Parse(Console.ReadLine());
            CheckForNegativeNumber(n);
            double result = Math.Sqrt(n);
            Console.WriteLine("Result: {0}", result);
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

    static void CheckForNegativeNumber(int number)
    {
        if (number < 0)
        {
            throw new ArithmeticException("Invalid number");
        }
    }
}
