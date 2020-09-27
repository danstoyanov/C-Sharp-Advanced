using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main()
        {
            var shopsDict = new SortedDictionary<string, Dictionary<string, double>>();
            ShopsInput(shopsDict);
            ShopsPrint(shopsDict);
        }

        public static void ShopsPrint(SortedDictionary<string, Dictionary<string, double>> shopsDict)
        {
            foreach (var (key, value) in shopsDict)
            {
                Console.WriteLine($"{key}->");
                foreach (var pair in value)
                {
                    Console.WriteLine($"Product: {pair.Key}, Price: {pair.Value}");
                }
            }
        }

        public static void ShopsInput(SortedDictionary<string, Dictionary<string, double>> shopsDict)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Revision")
            {
                var splitted = command.Split(", ").ToArray();
                var shop = splitted[0];
                var product = splitted[1];
                var price = double.Parse(splitted[2]);

                if (!shopsDict.ContainsKey(shop))
                {
                    shopsDict.Add(shop, new Dictionary<string, double>());
                    shopsDict[shop].Add(product, price);
                }

                if (!shopsDict[shop].ContainsKey(product))
                {
                    shopsDict[shop].Add(product, price);
                }
            }
        }
    }
}
