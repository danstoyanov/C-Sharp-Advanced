using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var clothes = new Dictionary<string, Dictionary<string, int>>();

            ClothesCheck(n, clothes);
            ClothesPrint(clothes);
        }

        public static void ClothesCheck(int n, Dictionary<string, Dictionary<string, int>> clothes)
        {
            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ")
                    .SelectMany(s => s.Split(','))
                    .ToList();
                var color = input[0];

                if (!clothes.ContainsKey(color))
                {
                    NewClothes(clothes, input, color);
                }
                else
                {
                    ContainsClothes(clothes, input, color);
                }
            }
        }
        public static void NewClothes(Dictionary<string, Dictionary<string, int>> clothes, List<string> input, string color)
        {
            clothes.Add(color, new Dictionary<string, int>());
            input.Remove(color);

            foreach (var item in input)
            {
                if (!clothes[color].ContainsKey(item))
                {
                    clothes[color].Add(item, 1);
                }
                else
                {
                    clothes[color][item]++;
                }
            }
        }
        public static void ContainsClothes(Dictionary<string, Dictionary<string, int>> clothes, List<string> input, string color)
        {
            input.Remove(color);

            foreach (var item in input)
            {
                if (!clothes[color].ContainsKey(item))
                {
                    clothes[color].Add(item, 1);
                }
                else
                {
                    clothes[color][item]++;
                }
            }
        }
        public static void ClothesPrint(Dictionary<string, Dictionary<string, int>> clothes)
        {
            var command = Console.ReadLine().Split().ToArray();
            string fount = string.Empty;

            foreach (var pair in clothes)
            {
                Console.WriteLine($"{pair.Key} clothes:");

                foreach (var curr in pair.Value)
                {
                    if (command[0] == pair.Key && command[1] == curr.Key)
                    {
                        fount = "(found!)";
                    }

                    Console.WriteLine($"* {curr.Key} - {curr.Value} {fount}");
                    fount = string.Empty;
                }
            }
        }
    }
}
