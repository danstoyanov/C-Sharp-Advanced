using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numsOfElements = nums[0];
            int toPop = nums[1];
            int numToFind = nums[2];

            var stackNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(stackNums);

            for (int i = 1; i <= toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
