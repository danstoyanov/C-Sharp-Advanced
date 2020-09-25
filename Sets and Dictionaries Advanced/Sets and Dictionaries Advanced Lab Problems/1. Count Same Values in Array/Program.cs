using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var dict = new Dictionary<double, int>();

            ValueCount(array, dict);
            PrintKeysCount(dict);
        }

        private static void PrintKeysCount(Dictionary<double, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(string.Join(" ", item.Key + " - " + item.Value + " times"));
            }
        }

        private static void ValueCount(double[] array, Dictionary<double, int> dict)
        {
            foreach (var item in array)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item]++;
                }
            }
        }
    }
}
