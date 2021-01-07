using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Stack
{
    public class StartUp
    {
        static void Main()
        {
            var mainArr = Console.ReadLine()
                .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToArray();

            var stack = new MyStack<string>(new List<string>(mainArr));
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                var currComm = command
                    .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (currComm[0])
                {
                    case "Push":
                        var element = currComm[1];
                        stack.Push(element);
                        break;

                    case "Pop":
                        stack.Pop();
                        break;
                }
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
/* 1. We need to create a stack structure 
 * 2. One collection for input elements ===> OK ! 
 * 3. Two functions (OOP) ====> OK !

 *  => Pop()
 *  => Push() == OK !

 *  WARNING !!! => . Keep in mind that the first element, which is popped is the last in the collection
 * 
 * 
 * 
 */
