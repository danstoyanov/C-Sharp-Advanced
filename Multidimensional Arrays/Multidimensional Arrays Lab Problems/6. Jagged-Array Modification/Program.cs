using System;
using System.ComponentModel;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n][];
            ReadMatrix(matrix);
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                var currComm = command.Split().ToArray();
                int row = int.Parse(currComm[1]);
                int col = int.Parse(currComm[2]);
                int value = int.Parse(currComm[3]);

                if (row >= matrix.Length || row < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (col >= matrix.Length || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (currComm[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (currComm[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (var curr in matrix)
            {
                Console.WriteLine(string.Join(" ", curr));
            }
        }

        static void ReadMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                var currRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = new int[currRow.Length];

                for (int col = 0; col < currRow.Length; col++)
                {
                    matrix[row][col] = currRow[col];
                }
            }
        }
    }
}
