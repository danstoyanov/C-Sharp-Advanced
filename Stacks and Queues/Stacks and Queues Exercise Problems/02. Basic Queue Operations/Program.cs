using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            var elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numsCount = elements[0];
            int removeCount = elements[1];
            int numToFind = elements[2];

            var queueElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(queueElements);

            for (int i = 1; i <= removeCount; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
