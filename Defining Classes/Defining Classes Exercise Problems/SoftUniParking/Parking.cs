using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        private int count;

        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.cars.Count;
            }
        }

        public string AddCar(Car car)
        {
            if (this.cars.Find(c => c.RegistrationNumber == car.RegistrationNumber) != null)
            {
                return "Car with that registration number, already exists!";
            }
            else
            {
                if (this.cars.Count >= this.Capacity)
                {
                    return "Parking is full!";
                }
                else
                {
                    this.cars.Add(car);
                    return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                }
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                Car curr = this.cars.Find(c => c.RegistrationNumber == registrationNumber);
                this.cars.Remove(curr);
                return $"Successfully removed {curr.RegistrationNumber}";
            }
            else
            {
                return $"Car with that registration number, doesn't exist!";
            }
        }

        public string GetCar(string registrationNumber)
        {
            return this.cars.Find(c => c.RegistrationNumber == registrationNumber).ToString();
        }

        // Void Method => RemoveSetOfRegistrationNumber !
    }
}
