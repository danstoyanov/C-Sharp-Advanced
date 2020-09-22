using System;
using System.ComponentModel;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main()
        {
            var size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new string[size[0], size[1]];
            ReadMatrix(matrix);

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                var currComm = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currComm[0] == "swap" && currComm.Length == 5)
                {
                    int row1 = int.Parse(currComm[1]);
                    int col1 = int.Parse(currComm[2]);
                    int row2 = int.Parse(currComm[3]);
                    int col2 = int.Parse(currComm[4]);

                    if (row1 >= 0 && row1 <= matrix.GetLength(0)
                        && col1 >= 0 && col1 <= matrix.GetLength(1)
                        && row2 >= 0 && row2 <= matrix.GetLength(0)
                        && col2 >= 0 && col2 <= matrix.GetLength(1))
                    {
                        string mainValue = string.Empty;
                        mainValue = matrix[row1, col1];

                        string firstValue = string.Empty;
                        firstValue = matrix[row2, col2];

                        matrix[row1, col1] = firstValue;
                        matrix[row2, col2] = mainValue;

                        MatrixPrint(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public static void MatrixPrint(string[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }
        }
    }
}
