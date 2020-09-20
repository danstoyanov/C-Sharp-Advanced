using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine();
                var elements = input.ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currElement = matrix[row, col];

                    if (currElement == symbol)
                    {
                        result += row + ", " + col;

                        Console.WriteLine($"({result})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
