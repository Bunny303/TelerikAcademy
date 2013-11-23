// 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractPalindrome
{
    static void Main()
    {
        string text = "ABBA have nice songs, exe is extension and bunnyynnub";

        string pattern = @"\w+";
        var words = Regex.Matches(text, pattern);

        foreach (Match word in words)
        {
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word.Value[i] != word.Value[word.Length - 1 - i])
                {
                    isPalindrome = false;        
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine(word);
            }
        }
    }
}
