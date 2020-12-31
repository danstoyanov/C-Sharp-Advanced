using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Generic_Swap_Method_String
{
    public class Box <T>
    {
        public Box(List<T> values)
        {
            this.Values = values;
        }
        public List<T> Values { get; set; } = new List<T>();

        public void Swap (int firstValue, int secondValue)
        {
            var tempValue = this.Values[firstValue];
            this.Values[firstValue] = this.Values[secondValue];
            this.Values[secondValue] = tempValue;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (T value in this.Values)
            {
                stringBuilder.AppendLine($"{value.GetType()}: {value}");
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
