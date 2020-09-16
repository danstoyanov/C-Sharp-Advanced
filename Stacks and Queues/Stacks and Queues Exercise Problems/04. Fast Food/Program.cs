using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main()
        {
            int food = int.Parse(Console.ReadLine());
            var ordersArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var orders = new Queue<int>(ordersArr);
            Console.WriteLine(orders.Max());

            for (int i = 0; i < ordersArr.Length; i++)
            {
                if (orders.Peek() <= food)
                {
                    food -= orders.Dequeue();
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                var arr = orders.ToArray();
                Console.WriteLine("Orders left: " + string.Join(" ", arr));
            }
        }
    }
}
