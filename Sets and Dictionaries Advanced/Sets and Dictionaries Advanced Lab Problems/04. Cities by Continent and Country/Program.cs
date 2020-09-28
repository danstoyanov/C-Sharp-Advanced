using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            InputInfo(count, dict);
            PrintInfo(dict);
        }

        public static void PrintInfo(Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            foreach (var (key, value) in dict)
            {
                Console.WriteLine($"{key}:");
                foreach (var pair in value)
                {
                    Console.WriteLine($"  {pair.Key} -> {string.Join(", ", pair.Value)}");
                }
            }
        }

        public static void InputInfo(int count, Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            for (int i = 1; i <= count; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }

                dict[continent][country].Add(city);
            }
        }
    }
}
