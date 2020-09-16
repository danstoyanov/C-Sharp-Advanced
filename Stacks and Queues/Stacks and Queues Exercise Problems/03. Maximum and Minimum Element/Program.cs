using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues_Exercise_Problems
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var myStack = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                var querie = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                switch (querie[0])
                {
                    case 1:
                        int element = querie[1];
                        myStack.Push(element);
                        break;

                    case 2:
                        if (myStack.Any()) myStack.Pop();
                        break;

                    case 3:

                        if (myStack.Any()) Console.WriteLine(myStack.Max());
                        break;

                    case 4:
                        if (myStack.Any()) Console.WriteLine(myStack.Min());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", myStack));
        }
    }
}
