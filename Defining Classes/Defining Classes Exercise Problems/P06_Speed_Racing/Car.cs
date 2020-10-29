using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace P06_Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double travelledDistance;

        public Car(string model)
        {
            this.Model = model;
        }

        public Car(string model, double fuelAmount, double fuelConsumption) 
            :this(model)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TravelledDistance
        {
            get
            {
                return this.travelledDistance;
            }
            set
            {
                this.travelledDistance = value;
            }
        }

        public static List<Car> Drive(List<Car> cars, 
            string carModel, double amountKm)
        {
            var driveCar = cars.Find(x => x.Model == carModel);
            var fuelNeed = amountKm * driveCar.FuelConsumption;

            if (fuelNeed > driveCar.FuelAmount)
            {
                System.Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                driveCar.TravelledDistance += amountKm;
                driveCar.FuelAmount -= fuelNeed;
            }

            return cars;
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance:F0}";
        }
    }
}
