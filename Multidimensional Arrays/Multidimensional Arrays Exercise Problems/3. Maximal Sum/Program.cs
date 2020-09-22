using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            var size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[size[0], size[1]];
            ReadMatrix(matrix);

            int sum = 0;
            int maxSum = int.MinValue;
            int maxSumRow = -1;
            int maxSumCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] 
                        + matrix[row, col + 1] 
                        + matrix[row, col + 2]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumCol = col;
                        maxSumRow = row;
                    }

                    sum = 0;
                }
            }

            PrintMatrix(matrix, maxSum, maxSumRow, maxSumCol);
        }

        private static void PrintMatrix(int[,] matrix, int maxSum, int maxSumRow, int maxSumCol)
        {
            Console.WriteLine("Sum = " + maxSum);
            Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]} {matrix[maxSumRow, maxSumCol + 2]}");
            Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]} {matrix[maxSumRow + 1, maxSumCol + 2]}");
            Console.WriteLine($"{matrix[maxSumRow + 2, maxSumCol]} {matrix[maxSumRow + 2, maxSumCol + 1]} {matrix[maxSumRow + 2, maxSumCol + 2]}");
        }

        public static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }
        }
    }
}
