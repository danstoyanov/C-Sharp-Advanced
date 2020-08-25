using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var myStack = new Stack<char>(input);

            while (myStack.Any())
            {
                Console.Write(myStack.Pop());
            }
        }
    }
}
