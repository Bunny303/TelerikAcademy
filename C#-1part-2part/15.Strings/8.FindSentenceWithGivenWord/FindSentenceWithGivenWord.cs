// 8. Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Text;
using System.Text.RegularExpressions;

class FindSentenceWithGivenWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        string pattern = @"\s*([^\.]*\b" + word + @"\b.*?\.)";
        MatchCollection markSentence = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (Match sentence in markSentence)
        {
            Console.WriteLine(sentence);
        }
    }
}
