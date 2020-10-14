using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        public static void Main()
        {
            int[] lilies, roses;
            ReadFromConsole(out lilies, out roses);

            var stack = new Stack<int>(lilies);
            var queue = new Queue<int>(roses);

            int wreathCount = 0;
            int wreathLeft = 0;

            while (stack.Count != 0  && queue.Count != 0)
            {
                int currLilie = stack.Peek();
                int currRose = queue.Peek();

                if (currLilie + currRose == 15)
                {
                    stack.Pop();
                    queue.Dequeue();
                    wreathCount++;
                }

                if (currLilie + currRose > 15)
                {
                    while (currLilie + currRose > 15)
                    {
                        currLilie -= 2;
                    }

                    if (stack.Count != 0 && (currLilie + currRose) == 15)
                    {
                        stack.Pop();
                        queue.Dequeue();
                        wreathCount++;
                    }
                }

                if (currLilie + currRose < 15)
                {
                    wreathLeft += currLilie + currRose;
                    stack.Pop();
                    queue.Dequeue();
                }
            }

            if (wreathLeft >= 15)
            {
                var leftFlow = wreathLeft / 15;
                wreathCount += leftFlow;
            }

            if (wreathCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathCount} wreaths more!");
            }
        }

        public static void ReadFromConsole(out int[] lilies, out int[] roses)
        {
            lilies = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            roses = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
        }
    }
}
