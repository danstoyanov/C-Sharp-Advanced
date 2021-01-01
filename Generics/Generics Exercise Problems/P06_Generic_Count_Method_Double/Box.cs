using System;
using System.Collections.Generic;

namespace P06_Generic_Count_Method_Double
{
    public class Box<T> where T : IComparable
    {
        public Box(List<T> values)
        {
            this.Values = values;
        }

        public List<T> Values { get; set; } = new List<T>();

        public int ValuesComparison(T currValue)
        {
            var count = 0;

            foreach (T value in this.Values)
            {
                if (value.CompareTo(currValue) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
