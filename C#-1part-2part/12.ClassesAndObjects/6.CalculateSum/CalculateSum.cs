//6. You are given a sequence of positive integer values written into a string, 
//separated by spaces. Write a function that reads these values from given string and calculates their sum. 
using System;

class CalculateSum
{
    static void Main()
    {
        Console.WriteLine(SumOfStringElements("43 68 9 23 318"));
    }
    static int SumOfStringElements(string inputString)
    {
        int sum = 0;
        int factor = 1;

        for (int i = inputString.Length-1; i >= 0; i--)
        {
            
            if (inputString[i] == ' ')
            {
                factor = 1;
            }
            else
            {
                sum = sum + (inputString[i] - '0') * factor;
                factor *= 10;
            }
        }

        return sum;
    }
}
