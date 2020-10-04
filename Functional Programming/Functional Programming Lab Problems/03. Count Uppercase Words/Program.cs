using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main()
        {
            Func<string, bool> isUpper = curr => char.IsUpper(curr[0]);
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(isUpper)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
