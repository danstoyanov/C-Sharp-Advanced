using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            var bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var filler = new Stack<int>(bullets);
            int bulletCount = 0;

            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var lockQueue = new Queue<int>(locks);
            int intelligenceValue = int.Parse(Console.ReadLine());

            while (lockQueue.Count > 0)
            {
                int shotBullet = barrelSize;

                for (int i = 1; i <= barrelSize; i++)
                {
                    if (filler.Count > 0 && lockQueue.Count > 0)
                    {
                        var currBullet = filler.Peek();
                        var currLock = lockQueue.Peek();

                        if (currBullet <= currLock)
                        {
                            Console.WriteLine("Bang!");
                            lockQueue.Dequeue();
                            filler.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Ping!");
                            filler.Pop();
                        }

                        bulletCount++;
                        shotBullet--;
                    }
                }

                if (shotBullet <= 0 && filler.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
                else
                {
                    break;
                }
            }

            if (lockQueue.Count == 0)
            {
                int bullerCost = bulletCount * bulletPrice;
                int earned = intelligenceValue - bullerCost;
                Console.WriteLine($"{filler.Count} bullets left. Earned ${earned}");
            }
            else
            {
                int locksLeft = lockQueue.Count;
                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }
        }
    }
}