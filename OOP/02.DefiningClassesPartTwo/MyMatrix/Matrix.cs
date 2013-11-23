using System;
using System.Linq;

namespace MyMatrix
{
    public class Matrix<T>
    {
        public int Cols { get; private set; }
        public int Rows { get; private set; }
        private T[,] matrix;

        public Matrix(int cols, int rows)
        {
            this.Cols = cols;
            this.Rows = rows;
            this.matrix = new T[cols, rows];
        }

        // 9. Access the inner matrix cell
        public T this[int rowPosition, int colPosition]
        {
            get
            {
                return matrix[rowPosition, colPosition];
            }

            set
            {
                matrix[rowPosition, colPosition] = value;
            }
        }

        // 10. Implement the operator +
        public static Matrix<T> operator + (Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            if (firstMatrix.Cols == secondMatrix.Cols && firstMatrix.Rows == secondMatrix.Rows)
            {
                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < firstMatrix.Cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                    }
                }
            }
            else
            {
                throw new ArgumentException("The matrixes isn't same size!");
            }
            return resultMatrix;
        }

        // 10. Implement the operator -
        public static Matrix<T> operator - (Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            if (firstMatrix.Cols == secondMatrix.Cols && firstMatrix.Rows == secondMatrix.Rows)
            {
                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < firstMatrix.Cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                    }
                }
            }
            else
            {
                throw new ArgumentException("The matrixes isn't same size!");
            }
            return resultMatrix;
        }

        // 10. Implement the operator *
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);
            if (firstMatrix.Cols == secondMatrix.Rows)
            {
                for (int i = 0; i < firstMatrix.Rows; i++)
                {
                    for (int j = 0; j < firstMatrix.Cols; j++)
                    {
                        for (int k = 0; k < firstMatrix.Cols; k++)
                        {
                            resultMatrix[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                        }
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("First matrix columns isn't same number as second matrix rows!");
            }
        }

        public static void PrintMatrix(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 10. Implement the operator true
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
