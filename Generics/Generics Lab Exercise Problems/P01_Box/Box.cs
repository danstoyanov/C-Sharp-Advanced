﻿using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> data;

        public Box()
        {
            this.data = new Stack<T>();
        }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.data.Push(item);
        }
        public T Remove()
        {
            return this.data.Pop();
        }
    }
}
