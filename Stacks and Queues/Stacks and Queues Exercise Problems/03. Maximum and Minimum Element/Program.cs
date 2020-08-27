using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 1; i <= count; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                switch (input[0])
                {
                    case 1:
                        stack.Push(input[1]);
                        break;
                    case 2:

                        if (stack.Count != 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:

                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Max());
                        }

                        break;
                    case 4:

                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
