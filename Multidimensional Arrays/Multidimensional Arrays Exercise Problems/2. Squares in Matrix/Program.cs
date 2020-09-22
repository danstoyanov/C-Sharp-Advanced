using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    public class Program
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new string[size[0], size[1]];
            ReadMatrix(matrix);

            int cells = 0;
            cells = CellsCheck(matrix, cells);

            Console.WriteLine(cells);
        }

        static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currRow = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }
        }
        static int CellsCheck(string[,] matrix, int cells)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    string currSymbol = matrix[row, col];

                    if (currSymbol == matrix[row, col + 1] &&
                        currSymbol == matrix[row + 1, col] &&
                        currSymbol == matrix[row + 1, col + 1])
                    {
                        cells++;
                    }
                }
            }

            return cells;
        }
    }
}
