using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Supermarket
{
    class Program
    {
        static void Main()
        {
            string name = string.Empty;
            var namesList = new Queue<string>();

            while ((name = Console.ReadLine()) != "End")
            {
                if (name.Contains("Paid"))
                {
                    while (namesList.Any())
                    {
                        Console.WriteLine(namesList.Dequeue());
                    }
                }
                else
                {
                    namesList.Enqueue(name);
                }
            }

            Console.WriteLine($"{namesList.Count} people remaining.");
        }
    }
}
