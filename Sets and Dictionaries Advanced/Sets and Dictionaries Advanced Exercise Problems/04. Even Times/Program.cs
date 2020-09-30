using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var counts = new Dictionary<int, int>();
            FillNums(n, counts);
            AppearsNumPrint(counts);
        }

        public static void AppearsNumPrint(Dictionary<int, int> counts)
        {
            var appears = counts.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, x => x.Value);

            foreach (var count in appears)
            {
                Console.WriteLine(count.Key);
            }
        }

        public static void FillNums(int n, Dictionary<int, int> counts)
        {
            for (int i = 1; i <= n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (!counts.ContainsKey(currNum))
                {
                    counts.Add(currNum, 0);
                }

                counts[currNum]++;
            }
        }
    }
}
