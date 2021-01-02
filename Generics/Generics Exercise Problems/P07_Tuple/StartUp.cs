using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split()
                .ToArray();

            var name = firstInput[0] + " " + firstInput[1];
            var city = firstInput[2];

            var secondInput = Console.ReadLine()
                .Split()
                .ToArray();

            var currName = secondInput[0];
            var liters = int.Parse(secondInput[1]);

            var thirdInput = Console.ReadLine()
                .Split()
                .ToArray();

            var integer = int.Parse(thirdInput[0]);
            var doubleNum = double.Parse(thirdInput[1]);

            var firstInfo = new Tuple<string, string>(name, city);
            var secondInfo = new Tuple<string, int>(currName, liters);
            var thirdInfo = new Tuple<int, double>(integer, doubleNum);

            Console.WriteLine(firstInfo);
            Console.WriteLine(secondInfo);
            Console.WriteLine(thirdInfo);
        }
    }
}
