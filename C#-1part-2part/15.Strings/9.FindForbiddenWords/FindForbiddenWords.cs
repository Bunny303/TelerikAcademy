// 9. We are given a string containing a list of forbidden words and a text containing some of these words. 
// Write a program that replaces the forbidden words with asterisks. 

using System;
using System.Text;
using System.Text.RegularExpressions;

class FindForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWords = "PHP, CLR, Microsoft";

        string[] words = forbiddenWords.Replace(" ", "").Split(',');
        foreach (var word in words)
        {
            text = Regex.Replace(text, @"\b" + word + @"\b", new string('*', word.Length));
        }
        Console.WriteLine(text);
    }
}
