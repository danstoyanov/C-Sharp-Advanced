using System;
using System.Collections.Generic;

namespace _02._Snake
{
    public class LairCordination
    {
        public int lairRow { get; set; }
        public int lairCol { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n][];

            var lair = new List<LairCordination>(); 
            var lairCount = 0;

            var snakeRow = -1;
            var snakeCol = -1;

            for (int row = 0; row < matrix.Length; row++)
            {
                var input = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = input;

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (matrix[row][col] == 'B')
                    {
                        lairCount++;

                        if (lairCount == 2)
                        {
                            LairCordination currInfo = new LairCordination();
                            currInfo.lairRow = row;
                            currInfo.lairCol = col;
                            lair.Add(currInfo);
                        }
                    }
                }


            }

            string command;
            var foodCount = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "up")
                {
                    if (snakeRow - 1 >= 0)
                    {
                        if (matrix[snakeRow - 1][snakeCol] == '*')
                        {
                            foodCount++;
                        }

                        if (matrix[snakeRow - 1][snakeCol] == 'B')
                        {
                            snakeRow--;
                            matrix[snakeRow][snakeCol] = '.';
                            matrix[snakeRow + 1][snakeCol] = '.';

                            snakeRow = lair[0].lairRow;
                            snakeCol = lair[0].lairCol;
                            matrix[snakeRow][snakeCol] = 'S';

                            lair.Clear();
                            continue;
                        }

                        snakeRow--;
                        matrix[snakeRow][snakeCol] = 'S';
                        matrix[snakeRow + 1][snakeCol] = '.';
                    }
                    else
                    {
                        matrix[snakeRow][snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (snakeRow + 1 < n)
                    {
                        if (matrix[snakeRow + 1][snakeCol] == '*')
                        {
                            foodCount++;
                        }

                        if (matrix[snakeRow + 1][snakeCol] == 'B')
                        {
                            snakeRow++;
                            matrix[snakeRow][snakeCol] = '.';
                            matrix[snakeRow - 1][snakeCol] = '.';

                            snakeRow = lair[0].lairRow;
                            snakeCol = lair[0].lairCol;
                            matrix[snakeRow][snakeCol] = 'S';

                            lair.Clear();
                            continue;
                        }

                        snakeRow++;
                        matrix[snakeRow][snakeCol] = 'S';
                        matrix[snakeRow - 1][snakeCol] = '.';
                    }
                    else
                    {
                        matrix[snakeRow][snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (snakeCol - 1 >= 0)
                    {
                        if (matrix[snakeRow][snakeCol - 1] == '*')
                        {
                            foodCount++;
                        }

                        if (matrix[snakeRow][snakeCol - 1] == 'B')
                        {
                            snakeCol--;
                            matrix[snakeRow][snakeCol] = '.';
                            matrix[snakeRow][snakeCol + 1] = '.';

                            snakeRow = lair[0].lairRow;
                            snakeCol = lair[0].lairCol;
                            matrix[snakeRow][snakeCol] = 'S';

                            lair.Clear();
                            continue;
                        }

                        snakeCol--;
                        matrix[snakeRow][snakeCol] = 'S';
                        matrix[snakeRow][snakeCol + 1] = '.';
                    }
                    else
                    {
                        matrix[snakeRow][snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (snakeCol + 1 < n)
                    {
                        if (matrix[snakeRow][snakeCol + 1] == '*')
                        {
                            foodCount++;
                        }

                        if (matrix[snakeRow][snakeCol + 1] == 'B')
                        {
                            snakeCol++;
                            matrix[snakeRow][snakeCol] = '.';
                            matrix[snakeRow][snakeCol - 1] = '.';

                            snakeRow = lair[0].lairRow;
                            snakeCol = lair[0].lairCol;
                            matrix[snakeRow][snakeCol] = 'S';

                            lair.Clear();
                            continue;
                        }

                        snakeCol++;
                        matrix[snakeRow][snakeCol] = 'S';
                        matrix[snakeRow][snakeCol - 1] = '.';
                    }
                    else
                    {
                        matrix[snakeRow][snakeCol] = '.';
                        Console.WriteLine("Game over!");
                        break;
                    }
                }

                if (foodCount == 10)
                {
                    break;
                }
            }

            if (foodCount >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodCount}");
            MatrixPrint(matrix);
        }

        private static void MatrixPrint(char[][] matrix) // delete element ! 
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }

                Console.WriteLine();
            }
        }
    }
}
