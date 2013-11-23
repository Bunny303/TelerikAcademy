// 7. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
// 8. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.Text.RegularExpressions;
using System.IO;

class ReplaceSubstringOrWord
{
    static void Main()
    {
        using (StreamReader inputFile = new StreamReader(@"../../inputFile.txt"))
        {
            //// Exercise 7
            //using (StreamWriter outputFileEx7 = new StreamWriter("../../outputFileEx7.txt"))
            //{
            //    for (string line = inputFile.ReadLine(); line != null; line = inputFile.ReadLine())
            //    {
            //        outputFileEx7.WriteLine(line.Replace("start", "finish"));            
            //    }
            //}

            // Exercise 8
            using (StreamWriter outputFileEx8 = new StreamWriter(@"../../outputFileEx8.txt"))
            {
                for (string line=inputFile.ReadLine(); line != null; line = inputFile.ReadLine())
                {
                    outputFileEx8.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                }
            }
        }
    }
}
