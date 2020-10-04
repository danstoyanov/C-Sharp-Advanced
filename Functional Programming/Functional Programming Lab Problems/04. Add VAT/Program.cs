using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main()
        {
            Func<string, double> doubleType = double.Parse;
            Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(doubleType)
                .Select(n => n = ((n + (n * 0.20))))
                .Select(n => new string($"{n:f2}"))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
