using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            this.data = new List<Car>();
            this.Type = type;
            this.Capacity = capacity;
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Car car)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            var currCar = this.data
                .FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);

            if (currCar != null)
            {
                this.data.Remove(currCar);
                return true;
            }

            return false;
        }

        public Car GetLatestCar()
        {
            if (this.Count == 0)
            {
                return null;
            }
            else
            {
                var currCarYear = this.data.OrderByDescending(c => c.Year).First();
                return currCarYear;
            }
        }

        public Car GetCar(string manufacturer, string model)
        {
            var currCar = this.data.FirstOrDefault(c => (c.Manufacturer == manufacturer && c.Model == model));

            if (currCar != null)
            {
                return currCar;
            }

            return null;
        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var currCar in this.data)
            {
                sb.AppendLine(currCar.ToString().Trim());
            }

            return sb.ToString().Trim();
        }
    }
}
