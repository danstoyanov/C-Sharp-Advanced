using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            Func<string, int> numParse = int.Parse;
            var nums = Console.ReadLine()
                .Split(", ")
                .Select(numParse)
                .ToList();

            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Sum());
        }
    }
}
