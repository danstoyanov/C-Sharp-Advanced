using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] autors)
        {
            this.Title = title;
            this.Year = year;
            this.Autors = new List<string>(autors);
        }

        public string Title { get; set; }
        public int Year { get; set; }

        public List<string> Autors { get; set; }
        public int CompareTo([AllowNull] Book other)
        {
            var result = this.Year.CompareTo(other.Year);

            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
