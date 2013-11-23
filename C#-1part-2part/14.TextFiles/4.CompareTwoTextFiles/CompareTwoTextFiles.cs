// 4. Write a program that compares two text files line by line and prints the number of lines 
//that are the same and the number of lines that are different. Assume the files have 
//equal number of lines.

using System;
using System.IO;

class CompareTwoTextFiles
{
    static void Main()
    {
        using (StreamReader readerFirst = new StreamReader(@"..\..\first.txt"))
        {
            using (StreamReader readerSecond = new StreamReader(@"..\..\second.txt"))
            {
                int sameCounter = 0;
                int diffCounter = 0;
                for (string lineFirst = readerFirst.ReadLine(), lineSecond = readerSecond.ReadLine(); 
                    (lineFirst != null)&&(lineSecond != null);
                    lineFirst = readerFirst.ReadLine(), lineSecond = readerSecond.ReadLine())
                {
                    if (lineFirst == lineSecond)
                    {
                        sameCounter++;
                    }
                    else
                    {
                        diffCounter++;
                    }
                }
                Console.WriteLine("Same lines are: {0}, different lines are: {1}", sameCounter, diffCounter);
            }
        }
    }
}
