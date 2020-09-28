using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main()
        {
            var cars = new HashSet<string>();
            ParkingCheck(cars);
            PrintCarsNums(cars);
        }

        public static void PrintCarsNums(HashSet<string> cars)
        {
            if (cars.Count() != 0)
            {
                foreach (var number in cars)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }

        public static void ParkingCheck(HashSet<string> cars)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var splited = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var currComm = splited[0];
                var number = splited[1];

                switch (currComm)
                {
                    case "IN":
                        cars.Add(number);
                        break;

                    case "OUT":
                        cars.Remove(number);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
