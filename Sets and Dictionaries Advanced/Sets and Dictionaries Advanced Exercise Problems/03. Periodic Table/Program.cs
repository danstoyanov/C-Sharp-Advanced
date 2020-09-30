using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            SetFill(n, set);
            SetPrint(set);
        }

        public static void SetPrint(HashSet<string> set)
        {
            var sortedSet = set.OrderBy(x => x).ToList();
            foreach (var element in sortedSet)
            {
                Console.Write(element + " ");
            }
        }

        public static void SetFill(int n, HashSet<string> set)
        {
            for (int i = 1; i <= n; i++)
            {
                var element = Console.ReadLine().Split();

                for (int j = 0; j < element.Length; j++)
                {
                    set.Add(element[j]);
                }
            }
        }
    }
}
