//12. Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

using System;

class LetterIndex
{
    static void Main()
    {
        char[] alfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string word = Console.ReadLine();
        
        foreach (char letter in word) //Read letter by letter the input word
        {
            for (int i = 0; i < alfabet.Length; i++) //Read the alfabet array
            {
                if (letter == alfabet[i]) //Compare letter from input word with elements from alfabet 
                {
                    Console.WriteLine(letter+" --> " + i);
                }
            }
                
        }
    }
}