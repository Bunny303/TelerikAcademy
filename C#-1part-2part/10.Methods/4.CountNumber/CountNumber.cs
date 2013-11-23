//4. Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

using System;

class CountNumber
{
    static void Main()
    {
        int[] intArray = { 2, 4, 5, 4, 7, 4, 2 };
        Console.Write("Please enter the searhing number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} times", CountSameNumber(intArray, inputNumber));
        
    }

    static int CountSameNumber(int[] intArray, int inputNumber)
    {
        int counter = 0;
        for (int i = 0; i < intArray.Length-1; i++)
        {
            if (intArray[i] == inputNumber)
            {
                counter++; 
            }
        }
        return counter;
    }
}
