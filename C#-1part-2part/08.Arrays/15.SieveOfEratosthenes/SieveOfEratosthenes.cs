// 15. Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
// http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        //Index are numbers 0-10 000 000;
        //Check first for [1..100]
        bool[] array = new bool[100000001]; //by default they're all false
        for (int i=2; i<array.Length; i++)
        {
            array[i] = true;//set all numbers to true
        }

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i])
            {
                for (long j = 2; (j * i) < array.Length; j++)
                {
                    array[j * i] = false;
                }
            }    
        }
        //If element of array is true, his index is prime number
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}
