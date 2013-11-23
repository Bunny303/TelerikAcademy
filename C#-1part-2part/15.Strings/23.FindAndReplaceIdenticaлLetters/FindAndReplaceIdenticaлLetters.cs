// 23. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

class FindAndReplaceIdenticaлLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaap";

        var result = new StringBuilder(input.Length);
        for (int i = 0; i < input.Length-1; i++)
        {
            if (input[i] != input[i+1])
            {
                result.Append(input[i]);
            }
        }
        result.Append(input[input.Length - 1]);
        
        Console.WriteLine(result);


    }
}
