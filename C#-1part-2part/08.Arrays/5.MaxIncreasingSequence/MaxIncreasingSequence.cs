//Write a program that finds the maximal increasing sequence in an array.

using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        //Declare array
        int[] myIntArray = { 1, 2, 20, 9, 10, 15, 3, 4, 30, 55, 60};

        int len = 1;
        int maxLen = 1;
        int index = 0;
        int maxIndex = 0;

        //Read and find
        for (int i = 0; i < (myIntArray.Length - 1); i++)
        {
            if (myIntArray[i] < myIntArray[i + 1])
            {
                len++;
                index = i - len + 2; //start index of sequence
                if (len > maxLen)
                {
                    maxLen = len;
                    maxIndex = index;
                }
            }
            else
            {
                len = 1;
            }
        }

        //Output

        for (int i = 0; i < myIntArray.Length; i++)
        {
            Console.Write(myIntArray[i] + " ");
        }
        Console.Write(" }--> { ");
        for (int i = maxIndex; i < maxIndex + maxLen; i++)
        {
            Console.Write(myIntArray[i] + " ");
        }
        Console.WriteLine("}");
    }
}

