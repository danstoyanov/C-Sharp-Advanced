using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());
            Predicate<int> disivisibleFunc = x => x % n != 0;
            Console.WriteLine(string.Join(" ", nums.FindAll(disivisibleFunc)));
        }
    }
}
