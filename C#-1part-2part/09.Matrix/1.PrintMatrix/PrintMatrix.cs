// 1. Write a program that fills and prints a matrix of size (n, n)
using System;

class PrintMatrix
{
    static void Main()
    {
        int n=4;
        int[,] intMatrix = new int [n,n];

        // a)
        for (int row = 0; row < n; row++)
        {
            intMatrix[row, 0] = row + 1;
            for (int col = 1; col < n; col++)
            {
                intMatrix[row, col] = intMatrix[row, 0] + (col * n);
            }
        }
        PrintMatrix(intMatrix, n);

        // b)
        for (int col = 0; col < n; col+=2)
        {
            for (int row = 0; row < n; row++)
            {
                intMatrix[row, col] = col*n+ row + 1;
            }
        }
        for (int col = 1; col < n; col += 2)
        {
            for (int row = 0; row < n; row++)
            {
                intMatrix[row, col] = (col+1)*n-row;
            }
        } 
        PrintMatrix(intMatrix, n);

        //c
        int counter = 1;
        int index = 1;
        while (counter <= n)
        {
            for (int col = 0; col < counter; col ++)
            {
                for (int row = col + n - counter; row >= col + n - counter; row--)
                {
                    intMatrix[row, col] = index;
                }
                index++;
            }
            counter++;
        }
        counter = 1;
        while (counter < n)
        {
            for (int col = counter; col < n; col++)
            {
                for (int row = col - counter; row >= col - counter; row--)
                {
                    intMatrix[row, col] = index;
                }
                index++;
            }
            counter++;
        }
        PrintMatrix(intMatrix, n);
    }

    static void PrintMatrix(int[,] intMatrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(intMatrix[row,col]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
