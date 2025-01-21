using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    using System;

    internal class Program4
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = GenerateMatrix(3, 3);
            int[,] matrix2 = GenerateMatrix(3, 3);

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);
            Console.WriteLine("Matrix 2:");
            PrintMatrix(matrix2);

            Console.WriteLine("Matrix 1 * 2:");
            PrintMatrix(MultiplyMatrixByNumber(matrix1, 2));
            Console.WriteLine("Matrix 1 + Matrix 2:");
            PrintMatrix(AddMatrices(matrix1, matrix2));
            Console.WriteLine("Matrix 1 * Matrix 2:");
            PrintMatrix(MultiplyMatrices(matrix1, matrix2));
        }

        static int[,] GenerateMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rnd.Next(1, 10);
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");
                Console.WriteLine();
            }
        }

        static int[,] MultiplyMatrixByNumber(int[,] matrix, int number)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    result[i, j] = matrix[i, j] * number;
            return result;
        }

        static int[,] AddMatrices(int[,] m1, int[,] m2)
        {
            int[,] result = new int[m1.GetLength(0), m1.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
                for (int j = 0; j < m1.GetLength(1); j++)
                    result[i, j] = m1[i, j] + m2[i, j];
            return result;
        }

        static int[,] MultiplyMatrices(int[,] m1, int[,] m2)
        {
            int[,] result = new int[m1.GetLength(0), m2.GetLength(1)];
            for (int i = 0; i < m1.GetLength(0); i++)
                for (int j = 0; j < m2.GetLength(1); j++)
                    for (int k = 0; k < m1.GetLength(1); k++)
                        result[i, j] += m1[i, k] * m2[k, j];
            return result;
        }
    }

}
