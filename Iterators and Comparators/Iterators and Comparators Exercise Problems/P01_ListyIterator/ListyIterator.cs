﻿using System;
using System.Collections.Generic;

namespace P01_ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        private int index;

        public ListyIterator(List<T> initialElements)
        {
            this.index = 0;
            this.elements = initialElements;
        }

        public int Count => this.elements.Count;

        public bool Move()
        {
            if (this.index + 1 < this.Count)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.index < this.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException($"Invalid Operation!");
            }

            Console.WriteLine(this.elements[index]);
        }
    }
}
