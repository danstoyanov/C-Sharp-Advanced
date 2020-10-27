using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person() // No arguments ! <== Constructor !
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this()// Argument with integer
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        {
            get { return this.Name = name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.Age = age; }
            set { this.age = value; }
        }
    }
}
