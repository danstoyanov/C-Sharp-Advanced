using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            var name1 = new Person();
            name1.Name = "Pesho";
            name1.Age = 20;

            var name2 = new Person();
            name2.Name = "Gosho";
            name2.Age = 18;

            var name3 = new Person();
            name3.Name = "Stamat";
            name3.Age = 43;

            Console.WriteLine($"{name1.Name} => {name1.Age}");
            Console.WriteLine($"{name2.Name} => {name2.Age}");
            Console.WriteLine($"{name3.Name} => {name3.Age}");
        }
    }
}
