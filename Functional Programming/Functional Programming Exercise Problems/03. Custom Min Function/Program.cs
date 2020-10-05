using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> minValue = minNum => arr.Min();
            Console.WriteLine(minValue(arr));
        }
    }
}
