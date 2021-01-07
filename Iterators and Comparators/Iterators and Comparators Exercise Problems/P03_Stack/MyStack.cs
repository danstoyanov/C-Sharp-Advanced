using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03_Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public MyStack(List<T> inputElements)
        {
            this.elements = inputElements;
        }
        public int Count => this.elements.Count;

        public void Push(T element)
        {
            this.elements.Add(element);
        }

        public void Pop() // ???? 
        {
            if (this.Count != 0)
            {
                this.elements.RemoveAt(this.elements.Count - 1);
            }
            else
            {
                Console.WriteLine($"No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
