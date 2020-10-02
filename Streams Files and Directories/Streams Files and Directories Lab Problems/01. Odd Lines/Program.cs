using System;
using System.IO;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main()
        {
            using var reader = new StreamReader("../../../input.txt");
            int count = 0;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (count % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                count++;
            }
        }
    }
}
