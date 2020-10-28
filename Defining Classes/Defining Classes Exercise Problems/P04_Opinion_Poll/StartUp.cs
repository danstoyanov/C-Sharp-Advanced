using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var personArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = personArgs[0];
                var age = int.Parse(personArgs[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            var result = family.GetAllPeopleAbove30();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
