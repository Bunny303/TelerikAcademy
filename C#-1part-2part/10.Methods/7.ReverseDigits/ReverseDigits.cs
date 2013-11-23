//7. Write a method that reverses the digits of given decimal number. Example: 256 --> 652

using System;
using System.Collections.Generic;

class ReverseDigits
{
    static void Main()
    {
        Console.WriteLine(ReverseNumber(54));
    }

    static int  ReverseNumber(int  inputNumber)
    {
        List<int > tempList = new List<int >();
        int  tempDigit = 0;

        while (inputNumber>0)
        {
            tempDigit = inputNumber % 10;
            inputNumber = inputNumber / 10;
            tempList.Add(tempDigit);
        }
        for (int i = 0; i < tempList.Count; i++)
        {
            inputNumber = inputNumber + (tempList[i] * (int)Math.Pow(10, (tempList.Count - i-1)));
        }
        return inputNumber;
    }
}
