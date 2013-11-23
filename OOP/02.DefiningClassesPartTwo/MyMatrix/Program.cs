using System;
using System.Linq;

namespace MyMatrix
{
    class Program
    {
        static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(2, 2);
            Matrix<int> secondMatrix = new Matrix<int>(2, 2);
            Matrix<int> thirdMatrix = new Matrix<int>(3, 2);

            // Fill cells in first and second test matrixes
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    firstMatrix[row, col] = 2;
                    secondMatrix[row, col] = 3;
                }
            }

            // Fill cells in third test matrix
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    thirdMatrix[row, col] = 5;
                }
            }

            // Test operator +
            Matrix<int>.PrintMatrix(firstMatrix + secondMatrix);

            //Test operator -
            Matrix<int>.PrintMatrix(secondMatrix - firstMatrix);

            //Test operator *
            Matrix<int>.PrintMatrix(firstMatrix * thirdMatrix);
            
            // Test operator true
            if (firstMatrix)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
    }
}
