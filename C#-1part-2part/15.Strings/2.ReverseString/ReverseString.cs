//2. Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        //Input string
        string input = Console.ReadLine();
        //Convert string to array from chars
        char[] reverse = input.ToCharArray();
        //Reverse array
        Array.Reverse(reverse);
        //Print result
        Console.WriteLine(reverse);
    }
}
