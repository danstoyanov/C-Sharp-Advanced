using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var myQueue = new Queue<string>();
            var oldStations = new List<string>();
            pumpIn(n, myQueue);

            var fuel = 0;
            int startIndex = 0;
            int movesCount = 0;

            while (true)
            {
                var currInfo = myQueue.Peek()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                oldStations.Add(myQueue.Peek());
                string info = myQueue.Dequeue();
                movesCount++;

                fuel += currInfo[0];
                var distance = currInfo[1];
                var index = currInfo[2];

                if (fuel >= distance)
                {
                    fuel -= distance;

                    if (movesCount == 1)
                    {
                        startIndex = index;
                    }
                }
                else
                {
                    fuel = 0;
                    movesCount = 0;
                    stationsClear(myQueue, oldStations);
                    startIndex = -1;
                }

                if (movesCount == n)
                {
                    break;
                }
            }

            Console.WriteLine(startIndex);
        }

        private static void stationsClear(Queue<string> myQueue, List<string> oldStations)
        {
            for (int i = 0; i < oldStations.Count; i++)
            {
                myQueue.Enqueue(oldStations[i]);
            }
            oldStations.Clear();
        }

        private static void pumpIn(int n, Queue<string> myQueue)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                myQueue.Enqueue(input += " " + i);
            }
        }
    }
}