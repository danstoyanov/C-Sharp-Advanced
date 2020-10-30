using System;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public Car()
        {

        }

        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public Car(string make, string model, int horsePower)
            : this(make, model)
        {
            this.HorsePower = horsePower;
        }

        public Car(string make, string model, int horsePower, string registrationNumber)
            : this(make, model, horsePower)
        {
            this.RegistrationNumber = registrationNumber;
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
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

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                this.registrationNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Make: {this.Make}")
                .AppendLine($"Model: {this.Model}")
                .AppendLine($"HorsePower: {this.HorsePower}")
                .AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
