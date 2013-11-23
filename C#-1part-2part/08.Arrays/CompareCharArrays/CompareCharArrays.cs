//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        //Declare arrays
        int[] firstArray = { 'a', 'b', 'c' };
        int[] secondArray = { 'a', 'b', 'c', 'c' };

        //Compare arrays
        bool isEqual = true;
        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    break;
                }
            }
        }
        else 
        {
            isEqual = false;
        }
        Console.WriteLine(isEqual);
    }
}

