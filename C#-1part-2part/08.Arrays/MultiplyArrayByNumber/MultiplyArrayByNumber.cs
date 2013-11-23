//Write a program that allocates array of 20 integers and initializes 
//each element by its index multiplied by 5. Print the obtained array on the console.

using System;

class MultiplyArrayByNumber
{
    static void Main()
    {
        int [] myIntArray = new int [20];
        for (int index = 0; index < myIntArray.Length; index++)
        {
            myIntArray[index] = index * 5;
            Console.Write(myIntArray[index] + " ");
        }
    }
}

