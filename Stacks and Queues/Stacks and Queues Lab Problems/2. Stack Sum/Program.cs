using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var myStack = new Stack<int>(arr);
            string input = Console.ReadLine();

            while (true)
            {
                var command = input.ToLower().Split().ToArray();
                var currComm = command[0];

                if (currComm.Contains("add"))
                {
                    myStack.Push(int.Parse(command[1]));
                    myStack.Push(int.Parse(command[2]));
                }
                else if (currComm.Contains("remove"))
                {
                    int itemRemove = int.Parse(command[1]);

                    if (myStack.Count >= itemRemove)
                    {
                        for (int i = 0; i < itemRemove; i++)
                        {
                            if (myStack.Any())
                            {
                                myStack.Pop();
                            }
                        }
                    }
                }
                else
                {
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {myStack.Sum()}");
        }
    }
}
