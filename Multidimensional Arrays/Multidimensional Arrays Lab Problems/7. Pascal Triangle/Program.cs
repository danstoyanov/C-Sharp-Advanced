using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var jagged = new long[n][];
            int startNum = 0;

            for (int row = 0; row < jagged.Length; row++)
            {
                startNum++;
                jagged[row] = new long[startNum];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    if (col == 0 || col == jagged[row].Length - 1)
                    {
                        jagged[row][col] = 1;
                    }
                    else
                    {
                        jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                    }
                }
            }

            PrintJagged(jagged);
        }

        private static void PrintJagged(long[][] jagged)
        {
            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
