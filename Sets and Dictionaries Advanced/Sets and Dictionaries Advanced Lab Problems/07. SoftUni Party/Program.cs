using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main()
        {
            var regular = new HashSet<string>();
            var vip = new HashSet<string>();
            GuestsNumsInput(regular, vip);
            GuestsNumsOutput(regular, vip);
            PrintGuests(regular, vip);
        }

        public static void PrintGuests(HashSet<string> regular, HashSet<string> vip)
        {
            Console.WriteLine(vip.Count + regular.Count);

            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }

        public static void GuestsNumsOutput(HashSet<string> regular, HashSet<string> vip)
        {
            string numbersOutput = string.Empty;

            while ((numbersOutput = Console.ReadLine()) != "END")
            {
                if (vip.Contains(numbersOutput))
                {
                    vip.Remove(numbersOutput);
                }

                if (regular.Contains(numbersOutput))
                {
                    regular.Remove(numbersOutput);
                }
            }
        }

        public static void GuestsNumsInput(HashSet<string> regular, HashSet<string> vip)
        {
            string numbersInput = string.Empty;

            while ((numbersInput = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit((char)numbersInput[0]))
                {
                    vip.Add(numbersInput);
                }
                else
                {
                    regular.Add(numbersInput);
                }
            }
        }
    }
}
