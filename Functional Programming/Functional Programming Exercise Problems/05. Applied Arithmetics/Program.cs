using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        nums = nums.Select(x => x + 1).ToList();
                        break;

                    case "multiply":
                        nums = nums.Select(x => x * 2).ToList();
                        break;

                    case "subtract":
                        nums = nums.Select(x => x - 1).ToList();
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                }
            }
        }
    }
}
