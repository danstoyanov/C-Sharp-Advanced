using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main()
        {
            var sets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var setN = new HashSet<int>();
            var setM = new HashSet<int>();

            SetsInput(sets, setN, setM);
            EqualSetsPrint(setN, setM);
        }

        public static void EqualSetsPrint(HashSet<int> setN, HashSet<int> setM)
        {
            var equalSets = new HashSet<int>();

            foreach (var n in setN)
            {
                foreach (var m in setM)
                {
                    if (n == m)
                    {
                        equalSets.Add(m);
                    }
                }
            }

            foreach (var set in equalSets)
            {
                Console.Write(set + " ");
            }
        }

        public static void SetsInput(int[] sets, HashSet<int> setN, HashSet<int> setM)
        {
            var n = sets[0];
            for (int i = 1; i <= n; i++)
            {
                var numN = int.Parse(Console.ReadLine());
                setN.Add(numN);
            }

            var m = sets[1];
            for (int i = 1; i <= m; i++)
            {
                var numM = int.Parse(Console.ReadLine());
                setM.Add(numM);
            }
        }
    }
}
