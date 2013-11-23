//Write a program that finds the most frequent number in an array. 
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} --> 4 (5 times)

using System;

class MostFrequentNumber
{
    static void Main()
    {
        //Sort array and find max equal elemets /ex.4/
        
        int[] myIntArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //Print unsorted array
        Console.Write("{");
        for (int i = 0; i < myIntArray.Length; i++)
        {
            Console.Write(myIntArray[i] + " ");
        }
        Console.Write("} ");

        Array.Sort(myIntArray);

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
                
                if (len > maxLen)
                {
                    maxLen = len;
                    maxIndex = i;
                }
            }
            else
            {
                len = 1;
            }
        }

        //Output
        Console.Write("--> {0} ({1} times)", myIntArray[maxIndex], maxLen);
        
        
    }
}
