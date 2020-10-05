using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var nums = new List<int>();

            Predicate<int> even = num => num % 2 == 0;
            Predicate<int> odd = num => num % 2 != 0;

            for (int i = arr[0]; i <= arr[1]; i++)
            {
                nums.Add(i);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "even":
                    Console.WriteLine(string.Join(" ", nums.FindAll(even)));
                    break;

                case "odd":
                    Console.WriteLine(string.Join(" ", nums.FindAll(odd)));
                    break;
            }
        }
    }
}
