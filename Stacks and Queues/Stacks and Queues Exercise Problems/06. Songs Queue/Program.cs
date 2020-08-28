using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main()
        {
            var soingsInput = Console.ReadLine().Split(", ");
            var songs = new Queue<string>(soingsInput);

            while (songs.Count > 0)
            {
                var command = Console.ReadLine();

                if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    var currSong = command.Replace("Add ", "");

                    if (!songs.Contains(currSong))
                    {
                        songs.Enqueue(currSong);
                    }
                    else
                    {
                        Console.WriteLine($"{currSong} is already contained!");
                    }

                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            if (songs.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
