using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Froggy
{
    public class StartUp
    {
        static void Main()
        {
            var array = Console.ReadLine()?
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stones = new Lake(array);
            var sortedStones = new List<int>();

            Console.WriteLine(string.Join(", ", stones));
        }
    }
}
