using System;
using System.Data;
using System.Linq;

namespace _1._Diagonal_Difference
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            ReadMatrix(matrix);

            int primary = 0;
            primary = PrimaryValue(matrix, primary);

            int secondary = 0;
            int count = -1;
            SecondaryValue(matrix, ref secondary, ref count);

            Console.WriteLine(Math.Abs(primary - secondary));
        }

        static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }
        }
        static int PrimaryValue(int[,] matrix, int leftSum)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    leftSum += matrix[row, col];
                    break;
                }
            }

            return leftSum;
        }
        static void SecondaryValue(int[,] matrix, ref int secondary, ref int count)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                count++;
                for (int row = count; row < matrix.GetLength(0); row++)
                {
                    secondary += matrix[row, col];
                    break;
                }
            }
        }
    }
}