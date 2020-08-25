using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main()
        {
            var numsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var evenNums = new Queue<int>();

            foreach (var num in numsInput)
            {
                if (num % 2 == 0)
                {
                    evenNums.Enqueue(num);
                }
            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
