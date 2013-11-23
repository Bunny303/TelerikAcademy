//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;

class MaxEqualElements
{
    static void Main()
    {
        //Declare array
        int[] myIntArray = { 1, 1, 2, 2, 2, 2, 3, 3, 3, 4, 4};

        int len = 1;
        int maxLen = 1;
        int index = 0;
        int maxIndex = 0;

        //Read and find
        for (int i = 0; i < (myIntArray.Length - 1); i++)
        {
            if (myIntArray[i] == myIntArray[i + 1])
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
        Console.Write(" {");
        for (int i = 0; i < myIntArray.Length; i++)
        {
            Console.Write(myIntArray[i] + " ");
        }
        Console.Write(" }--> { ");
        for (int i = maxIndex; i < maxIndex + maxLen; i++)
        {
            Console.Write(myIntArray[i]+" ");
        }
        Console.WriteLine("}");
        

    }
}

