using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class AgeInfoType
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<AgeInfoType>();

            for (int i = 1; i <= n; i++)
            {
                var input = Console
                    .ReadLine()
                    .Split(", ")
                    .ToArray();

                var func = new AgeInfoType
                {
                    Name = input[0],
                    Age = int.Parse(input[1])
                };

                list.Add(func);
            }

            var condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<AgeInfoType, bool> filter = condition switch
            {
                "younger" => i => i.Age <= age,
                "older" => i => i.Age >= age,
                _ => i => true
            };

            var format = Console.ReadLine();

            Func<AgeInfoType, string> output = format switch
            {
                "name age" => i => $"{i.Name} - {i.Age}",
                "name" => i => i.Name,
                _ => null
            };

            list
                .Where(filter)
                .Select(output)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
