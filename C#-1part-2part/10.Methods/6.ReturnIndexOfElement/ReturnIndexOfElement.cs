//6. Write a method that returns the index of the first element in array that is bigger than its neighbors, 
//or -1, if there’s no such element. Use the method from the previous exercise.

using System;

class ReturnIndexOfElement
{
    static void Main()
    {
        //int[] intArray = { 2, 4, 5, 4, 7, 4, 2 };
        //ReturnIndexOfComparingNumbers(intArray);
    }

    static bool CompareNumber(int[] intArray, int index)
    {
        bool comparingResult = false;
        if ((index > 0) && (index < (intArray.Length - 1)))
        {
            if ((intArray[index] > intArray[index - 1]) && (intArray[index] > intArray[index + 1]))
            {
                comparingResult = true;
            }
        }
        return comparingResult;
    }

    static void ReturnIndexOfComparingNumbers(int[] intArray)
    {
        for (int index = 0; index < intArray.Length; index++)
        {
            if (CompareNumber(intArray, index))
            {
                Console.WriteLine(index);
                return;
            }
        }
        Console.WriteLine("-1");
    }
}
