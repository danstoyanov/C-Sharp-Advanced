using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(input);
            int currIndex = 1;

            while (queue.Count > 1)
            {
                var currName = queue.Dequeue();

                if (currIndex == n)
                {
                    Console.WriteLine($"Removed {currName}");
                    currIndex = 0;
                }
                else
                {
                    queue.Enqueue(currName);
                }

                currIndex++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
