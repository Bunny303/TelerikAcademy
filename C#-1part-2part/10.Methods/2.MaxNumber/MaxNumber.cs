//2. Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class MaxNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 integer numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int maxNumber = 0;

        maxNumber = GetMax(a, b);
        maxNumber = GetMax(c, maxNumber);
        Console.WriteLine("The biggest of the input numbers is: {0}", maxNumber);
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = firstNumber;
        if (firstNumber < secondNumber)
        {
            maxNumber = secondNumber;
        }
        return maxNumber;
    }
}
