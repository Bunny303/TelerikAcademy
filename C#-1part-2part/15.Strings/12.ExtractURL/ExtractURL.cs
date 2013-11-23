// 12. Write a program that parses an URL address given in the format:
// 	and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		// [protocol] = "http"
		// [server] = "www.devbg.org"
		// [resource] = "/forum/index.php"

using System;
using System.Text.RegularExpressions;

class ExtractURL
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";

        string pattern = "(.*)://(.*?)(/.*)";
        MatchCollection parts = Regex.Matches(url, pattern);
        
        foreach (Match match in parts)
        {
            Console.WriteLine("[protocol] = \"{0}\"", match.Groups[1].Value);
            Console.WriteLine("[server] = \"{0}\"", match.Groups[2].Value);
            Console.WriteLine("[resource] = \"{0}\"", match.Groups[3].Value);
        }
    }
}
 