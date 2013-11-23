//5. Write a method that checks if the element at given position in given array of integers 
//is bigger than its two neighbors (when such exist).

using System;

class CompareElemets
{
    static void Main()
    {
        //int[] intArray = { 2, 4, 5, 4, 7, 4, 2 };
        //int index = 4;

        //Console.WriteLine(CompareNumber(intArray, index));
    }

    static bool CompareNumber(int[] intArray, int index)
    {
        bool comparingResult = false;
        if ((index > 0) && (index<(intArray.Length-1)))
        {
            if ((intArray[index] > intArray[index - 1]) && (intArray[index] > intArray[index + 1]))
            {
                comparingResult = true;
            }
        }
        return comparingResult;
    }
}
