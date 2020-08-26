using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main()
        {
            int totalCarPassed = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int carCounter = 0;
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("green"))
                {
                    for (int i = 1; i <= totalCarPassed; i++)
                    {
                        if (queue.Count <= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            carCounter++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

            Console.WriteLine($"{carCounter} cars passed the crossroads.");
        }
    }
}
