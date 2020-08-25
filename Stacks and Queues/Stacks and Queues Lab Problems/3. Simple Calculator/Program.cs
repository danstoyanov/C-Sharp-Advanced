using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var symbol = stack.Pop();
                var secondNum = int.Parse(stack.Pop());

                var result = 0;

                switch (symbol)
                {
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                }

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
