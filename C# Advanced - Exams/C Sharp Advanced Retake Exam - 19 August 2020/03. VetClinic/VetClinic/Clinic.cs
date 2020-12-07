using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        private int capacity;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public int Capacity
        {
            get => this.capacity;
            set => this.capacity = value;
        }

        public int Count => this.data.Count;

        public void Add(Pet pet)
        {
            if (this.data.Count < capacity)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            var currPetName = this.data.FirstOrDefault(p => p.Name == name);

            if (currPetName != null)
            {
                this.data.Remove(currPetName);
                return true;
            }

            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            var currName = this.data.FirstOrDefault(p => p.Name == name && p.Owner == owner);

            return currName;
        }

        public Pet GetOldestPet()
        {
            var maxValue = this.data.Max(p => p.Age);
            var oldestPet = this.data.FirstOrDefault(p => p.Age == maxValue);

            return oldestPet;
        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");

            foreach (var pet in this.data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }
    }
}
