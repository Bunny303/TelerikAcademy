using System;

class Program
{
    static void Main()
    {
        //Input
        int N = int.Parse(Console.ReadLine());

        //Output
        
        //First row
        for (int firstRow = 1; firstRow <= N; firstRow++)
        {
            Console.Write(".");
        }
        for (int firstRow = (N+1); firstRow <= (2*N); firstRow++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        
        //Middle Part
        int counter = 0;
        for (int row = 1; row <= (N - 1); row++)
            {
                for (int col = 1; col <= (2 * N-1); col++)
                {
                    if (col == (N - counter))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.Write("*");
                counter ++;
                Console.WriteLine();
            }

        //Last row
        for (int lastRow = 1; lastRow <= (2*N); lastRow++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
