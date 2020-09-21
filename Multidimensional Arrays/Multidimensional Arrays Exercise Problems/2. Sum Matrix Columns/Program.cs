using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main()
        {
            var size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[size[0], size[1]];

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

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfElements = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfElements += matrix[row, col];
                }

                Console.WriteLine(sumOfElements);
            }
        }
    }
}
