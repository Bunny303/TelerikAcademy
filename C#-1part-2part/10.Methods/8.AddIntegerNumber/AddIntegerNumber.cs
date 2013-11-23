//8. Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class AddIntegerNumber
{
    static void Main()
    {
        //AddsTwoPositiveInteger(10000, 487);
    }

    static void AddsTwoPositiveInteger (int a, int b)
    {
        List<int> aList = new List<int>();
        List<int> bList = new List<int>();
        int tempDigit = 0;

        while (a > 0)
        {
            tempDigit = a % 10;
            a = a / 10;
            aList.Add(tempDigit);
        }
        while (b > 0)
        {
            tempDigit = b % 10;
            b = b / 10;
            bList.Add(tempDigit);
        }
    }
}
