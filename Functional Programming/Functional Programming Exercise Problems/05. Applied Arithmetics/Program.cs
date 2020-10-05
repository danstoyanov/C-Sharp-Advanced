using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main()
        {
            Func<int, int> addFunc = x => x + 1;
            Func<int, int> multiplyFunc = x => x * 2;
            Func<int, int> subtractFunc = x => x - 1;
            Action<int[]> printFunc = x => Console.WriteLine(string.Join(" ", x));

            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Contains("print"))
                {
                    printFunc(nums.ToArray());
                }
                else
                {
                    Func<int, int> test = command switch
                    {
                        "add" => addFunc,
                        "multiply" => multiplyFunc,
                        "subtract" => subtractFunc,
                    };

                    nums = nums.Select(test).ToList();
                }
            }
        }
    }
}
