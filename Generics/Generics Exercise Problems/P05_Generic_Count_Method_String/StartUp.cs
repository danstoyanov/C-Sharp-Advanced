using System;
using System.Collections.Generic;

namespace P05_Generic_Count_Method_String
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

            var elemetnForComparison = Console.ReadLine();
            var box = new Box<string>(values);

            Console.WriteLine(box.CountOfGreaterElements(elemetnForComparison));
        }
    }
}
