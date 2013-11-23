// 11. Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsWithPrefix
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../test.txt"))
        {
            using (StreamWriter writer = new StreamWriter("../../testTemp.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                }
            }
        }

        File.Delete(@"../../test.txt");
        File.Move(@"../../testTemp.txt", @"../../test.txt");
    }
}
