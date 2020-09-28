﻿using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int name = 1; name <= n; name++)
            {
                var currName = Console.ReadLine();
                names.Add(currName);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
