using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Speed_Racing
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                var model = carArgs[0];
                var fuelAmount = int.Parse(carArgs[1]);
                var fuelConsumptionFor1km = double.Parse(carArgs[2]);

                var currCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(currCar);
            }

            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var currComm = command.Split().ToArray();
                var carModel = currComm[1];
                var amountKm = double.Parse(currComm[2]);

                Car.Drive(cars, carModel, amountKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
