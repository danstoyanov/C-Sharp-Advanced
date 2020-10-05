using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split()
                .Select(x => "Sir " + x)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
