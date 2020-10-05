using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split()
                .Select(x => x)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
