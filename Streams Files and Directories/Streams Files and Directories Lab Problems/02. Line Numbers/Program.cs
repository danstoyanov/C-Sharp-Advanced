using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main()
        {
            using var reader = new StreamReader("../../../NumFile.txt");
            int count = 0;

            while (true)
            {
                count++;
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                Console.WriteLine($"{count}. {line}");
            }
        }
    }
}
