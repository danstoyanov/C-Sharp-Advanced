using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    public class Program
    {
        static void Main()
        {
            var effects = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var casings = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var daturaBobs = 40;
            var daturaBobsCount = 0;

            var cherryBobs = 60;
            var cherryBomsCount = 0;

            var smokeDecoyBoms = 120;
            var smokeDecoyBomsCount = 0;

            var stack = new Stack<int>(casings);
            var queue = new Queue<int>(effects);

            while (stack.Count != 0 && queue.Count != 0)
            {
                var sum = stack.Pop() + queue.Dequeue();

                while (sum != daturaBobs && sum != cherryBobs && sum != smokeDecoyBoms)
                {
                    sum -= 5;
                }

                if (sum == daturaBobs) // 40
                {
                    daturaBobsCount++;
                }
                else if (sum == cherryBobs) // 60 
                {
                    cherryBomsCount++;
                }
                else if (sum == smokeDecoyBoms) // 120
                {
                    smokeDecoyBomsCount++;
                }

                if (daturaBobsCount >= 3 && cherryBomsCount >= 3 && smokeDecoyBomsCount >= 3)
                {
                    break;
                }
            }

            if (daturaBobsCount >= 3 && cherryBomsCount >= 3 && smokeDecoyBomsCount >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            
            if (queue.Count != 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", queue)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (stack.Count != 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", stack)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBomsCount}");
            Console.WriteLine($"Datura Bombs: {daturaBobsCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBomsCount}");
        }
    }
}
