using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P05_Generic_Count_Method_String
{
    public class Box <T> where T : IComparable
    {
        public Box(List<T> values)
        {
            this.Values = values;
        }

        public List<T> Values { get; set; } = new List<T>();

        public int CountOfGreaterElements (T currValue)
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
