using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currIndex = input[i];

                if (currIndex == '(')
                {
                    stack.Push(i);
                }
                else if (currIndex == ')')
                {
                    int indexOfOpen = stack.Pop();

                    string result = input.Substring(indexOfOpen, i - indexOfOpen + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
