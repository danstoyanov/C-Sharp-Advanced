using System;
using System.Collections.Generic;

namespace P06_Generic_Count_Method_Double
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var values = new List<double>();

            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                values.Add(number);
            }

            var testNumber = double.Parse(Console.ReadLine());
            var box = new Box<double>(values);

            Console.WriteLine(box.ValuesComparison(testNumber));
        }
    }
}
