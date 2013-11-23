// 2. Write a method ReadNumber(int start, int end) that enters an integer number in given range 
//[start…end]. If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadTenNumbers
{
    static void Main()
    {
        try
        {
            int start = 1;
            int end = 100;

            for (int i = 0; i < 10; i++)
            {
                start = ReadNumber(start, end);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Input number is not in valid the range");
        }

    }

    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter number between {0} and {1}: ", start, end);
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException("Input number is not in valid the range");
        }  
 
        return number;
    }
}
