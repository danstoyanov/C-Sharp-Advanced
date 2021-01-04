using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book
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
    }
}
