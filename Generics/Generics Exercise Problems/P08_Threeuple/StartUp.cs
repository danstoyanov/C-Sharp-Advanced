using System;
using System.Linq;

namespace P08_Threeuple
{
    public class StartUp
    {
        static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split()
                .ToArray();

            var firstName = firstInput[0];
            var lastName = firstInput[1];
            var address = firstInput[2];
            var town = firstInput[3];

            var secondInput = Console.ReadLine()
                .Split()
                .ToArray();

            var secondName = secondInput[0];
            var litersOfbeer = int.Parse(secondInput[1]);
            var drunkOrNot = secondInput[2] == "drunk" ? true : false;

            var thirdInput = Console.ReadLine()
                .Split()
                .ToArray();

            var thirdName = thirdInput[0];
            var balance = double.Parse(thirdInput[1]);
            var bankName = thirdInput[2];

            var firstInfo = new Threeuple<string, string, string>((firstName + " " + lastName), address, town);
            var secondInfo = new Threeuple<string, int, bool>(secondName, litersOfbeer, drunkOrNot);
            var thirdInfo = new Threeuple<string, double, string>(thirdName, balance, bankName);

            Console.WriteLine(firstInfo);
            Console.WriteLine(secondInfo);
            Console.WriteLine(thirdInfo);
        }
    }
}
