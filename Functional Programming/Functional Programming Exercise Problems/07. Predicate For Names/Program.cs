using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main()
        {
            int nameLenght = int.Parse(Console.ReadLine());
            Func<string, bool> isLess = name => name.Length <= nameLenght;
            Console.ReadLine()
                .Split()
                .Where(isLess)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
