using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public delegate void PrintDelegate(string name);

    internal class Person
    {
        private string surname;
        private string name;
        
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public override string ToString()
        {
            return $"{surname} {name}";
        }
    }
}
