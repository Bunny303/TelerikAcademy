//2. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSumOfMatrixElements
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int m = int.Parse(Console.ReadLine());
        int[,] intMatrix = new int[n,m];

        ReadMatrix(intMatrix, n, m);

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < n - 2; row++)
            for (int col = 0; col < m - 2; col++)
            {
                int sum = intMatrix[row, col] + intMatrix[row, col + 1] + intMatrix[row, col + 2] + intMatrix[row + 1, col] + intMatrix[row + 1, col + 1] + intMatrix[row + 1, col + 2] + intMatrix[row + 2, col + 1] + intMatrix[row + 2, col + 1] +intMatrix[row + 2, col + 2] ;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }

        PrintMatrix(intMatrix, bestRow, bestCol, 3, 3);
    }

    static int[,] ReadMatrix(int[,] intMatrix, int n, int m)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                intMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        return intMatrix;
    }

    static void PrintMatrix(int[,] intMatrix, int startRow, int startCol, int n, int m)
    {
        for (int row = startRow; row <= n; row++)
        {
            for (int col = startCol; col <= m; col++)
            {
                Console.Write(intMatrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
