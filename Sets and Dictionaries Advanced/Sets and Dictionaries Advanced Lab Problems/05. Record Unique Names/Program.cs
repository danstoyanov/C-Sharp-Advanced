using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            NamesInput(n, names);
            NamesPrint(names);
        }

        public static void NamesPrint(HashSet<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void NamesInput(int n, HashSet<string> names)
        {
            for (int i = 1; i <= n; i++)
            {
                var nameInput = Console.ReadLine();
                names.Add(nameInput);
            }
        }
    }
}
