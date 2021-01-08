using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Comparing_Objects
{
    public class StartUp
    {
        static void Main()
        {
            var command = string.Empty;
            var people = new List<Person>();

            while ((command = Console.ReadLine()) != "END")
            {
                var cmdArg = command?
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = cmdArg[0];
                var age = int.Parse(cmdArg[1]);
                var town = cmdArg[2];

                var newPerson = new Person(name, age, town);

                people.Add(newPerson);
            }

            var n = int.Parse(Console.ReadLine());

            Person comparedPerson = people[n - 1];

            int samePersonCount = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(comparedPerson) == 0)
                {
                    samePersonCount++;
                }
            }

            if (samePersonCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{samePersonCount} {people.Count - samePersonCount} {people.Count}");
            }
        }
    }
}
