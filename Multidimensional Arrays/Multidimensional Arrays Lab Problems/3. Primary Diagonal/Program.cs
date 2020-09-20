using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];

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

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    int value = matrix[row, col];
                    sum += value;
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
