using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Classroom
    {
        private string name;
        private Person[] persons;
        public string Name { get=>this.name; }

        public Classroom(string name,Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
