// 2. Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenatesTwoText
{
    static void Main()
    {
        using (StreamReader readerFirst = new StreamReader(@"..\..\first.txt"))
        {
            using (StreamReader readerSecond = new StreamReader(@"..\..\second.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\newFile.txt"))
                {
                    for (var line = readerFirst.ReadLine(); line != null; line = readerFirst.ReadLine())
                    {
                        writer.WriteLine(line);
                    }
                    for (var line = readerSecond.ReadLine(); line != null; line = readerSecond.ReadLine())
                    {
                        writer.WriteLine(line);
                    }
                }
            }

        }
    }
}
