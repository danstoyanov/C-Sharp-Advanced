using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main()
        {
            var cups = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var cupsQueue = new Queue<int>(cups);
            
            var bottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stackBottles = new Stack<int>(bottles);

            int totalWastedWater = 0;

            while (cupsQueue.Count > 0)
            {
                var currBottle = stackBottles.Peek();
                var currCupValue = cupsQueue.Peek();
                
                if (currBottle >= currCupValue)
                {
                    totalWastedWater += currBottle - currCupValue;
                    stackBottles.Pop();
                    cupsQueue.Dequeue();
                }
                else // WARNING !!!!!!!!!!!
                {
                    currCupValue = cupsQueue.Dequeue();
                    var result = currCupValue - currBottle;
                    stackBottles.Pop();
                    var currCups = cupsQueue.ToList();
                    currCups.Insert(0, result);
                    cupsQueue = new Queue<int>(currCups);
                }

                if (stackBottles.Count <= 0)
                {
                    break;
                }
            }

            if (stackBottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stackBottles)}");
            }
            else if (cupsQueue.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
            }

            Console.WriteLine($"Wasted litters of water: {totalWastedWater}");
        }
    }
}
