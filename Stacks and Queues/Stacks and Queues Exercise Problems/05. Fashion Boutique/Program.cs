using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());
            var clothes = new Stack<int>(input.Reverse());
            int sum = 0;
            int boxes = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];

                if (sum <= capacity)
                {
                    clothes.Pop();
                }
                else
                {
                    boxes++;
                    sum = input[i];
                }
            }

            if (sum != 0)
            {
                Console.WriteLine(boxes += 1);
            }
            else
            {
                Console.WriteLine(boxes);
            }
        }
    }
}
