// 13. Write a program that reverses the words in given sentence.
// Мазало стана :(

using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;


class ReverseWords
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";

        string pattern = @"\s+|,\s*|\.\s*|!\s*|\?\s*";
        
        List<string> words = new List<string>();      
        List<string> signs = new List<string>();

        foreach (string word in Regex.Split(input, pattern))
        {
            words.Add(word);
        }
        foreach (Match sign in Regex.Matches(input, pattern))
        {
            signs.Add(sign.Value);
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < signs.Count; i++)
        {
            result.Append(words[words.Count - 2 - i] + signs[i]);
        }
        Console.WriteLine(result);
                        
    }
}
