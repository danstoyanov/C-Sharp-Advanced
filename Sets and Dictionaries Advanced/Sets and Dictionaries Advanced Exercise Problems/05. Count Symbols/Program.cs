using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            var dict = new Dictionary<char, int>();
            DictFill(text, dict);
            DictPrint(dict);
        }

        public static void DictPrint(Dictionary<char, int> dict)
        {
            var sorted = dict.OrderBy(x => x.Key);

            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }

        public static void DictFill(char[] text, Dictionary<char, int> dict)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!dict.ContainsKey(text[i]))
                {
                    dict.Add(text[i], 1);
                }
                else
                {
                    dict[text[i]]++;
                }
            }
        }
    }
}
