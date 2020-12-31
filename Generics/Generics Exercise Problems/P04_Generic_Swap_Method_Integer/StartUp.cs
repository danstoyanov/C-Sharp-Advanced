using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Generic_Swap_Method_Integer
{
    public class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var values = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                values.Add(number);
            }

            var indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var box = new Box<int>(values);
            box.Swap(indexes[0], indexes[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
