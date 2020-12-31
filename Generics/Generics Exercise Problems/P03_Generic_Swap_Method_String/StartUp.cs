using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Generic_Swap_Method_String
{
    public class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var values = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                values.Add(input);
            }

            var indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var box = new Box<string>(values);
            box.Swap(indexes[0], indexes[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
