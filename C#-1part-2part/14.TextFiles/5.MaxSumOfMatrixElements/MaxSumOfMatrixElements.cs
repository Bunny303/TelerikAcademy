// 5. Write a program that reads a text file containing a square matrix of numbers and finds 
//in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input 
//file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. 

using System;
using System.IO;

class MaxSumOfMatrixElements
{
    static void Main()
    {
        //Read file and save numbers in new array
        using (StreamReader matrix = new StreamReader(@"..\..\matrix.txt"))
        {
            int N = int.Parse(matrix.ReadLine());
            int[,] intMatrix = new int[N,N];

            for (int i = 0; i < N; i++)
            {
                string[] numbers = matrix.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                    intMatrix[i, j] = int.Parse(numbers[j]); 
            }

            //Find max sum 
            int bestSum = int.MinValue;
            int sum = 0;
            for (int row = 0; row < N - 1; row++)
            {
                for (int col = 0; col < N - 1; col++)
                {
                    sum = intMatrix[row, col] + intMatrix[row, col + 1] + intMatrix[row + 1, col] + intMatrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            //Save result in new text file
            using (StreamWriter result = new StreamWriter("../../result.txt"))
            {
                result.WriteLine(bestSum);
            }
        }
    }
}
