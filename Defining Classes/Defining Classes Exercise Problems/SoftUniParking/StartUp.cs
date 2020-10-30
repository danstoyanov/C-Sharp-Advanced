using System;

namespace SoftUniParking
{
    public class StartUp
    {
        static void Main()
        {
            // First Car
            var make1 = "Toyota";
            var model = "Corolla";
            var power1 = 100;
            var number1 = "A5344C";

            var car1 = new Car(make1, model, power1, number1);

            // Second Car 
            var make2 = "Ford";
            var model2 = "F150";
            var power2 = 180;
            var number2 = "A9822C";

            var car2 = new Car(make2, model2, power2, number2);

            var parking = new Parking(1);
            Console.WriteLine(parking.AddCar(car1));
            Console.WriteLine(parking.AddCar(car2));
            Console.WriteLine(parking.AddCar(car2));

            Console.WriteLine(parking.GetCar("A5344C").ToString());

        }
    }
}
