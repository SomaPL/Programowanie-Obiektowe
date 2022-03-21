using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Person
    {
        protected string name;
        protected int age;

        public string Name { get => this.name; }
        public int Age { get => this.age; }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            return other.name == this.name && other.age == this.age;
        }

        public override string ToString()
        {
            return this.name + "(" + this.age.ToString() + "y.o)";
        }
    }
}
