using System;

class Fibonacci
{
    static void Main()
    {
        decimal FirstNumber = 0;
        decimal SecondNumber = 1;
        decimal sum = 0;
        Console.WriteLine(FirstNumber);
        Console.WriteLine(SecondNumber);
        for (int i = 1; i < 100; i++)
        {
            sum = FirstNumber + SecondNumber;
            FirstNumber = SecondNumber;
            SecondNumber = sum;
            Console.WriteLine(sum);
        }

    }
}