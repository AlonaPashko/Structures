using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Peoples
    {
        protected List<Person> persons;
        protected string guider;

        public string Guider { get => guider; set => guider = value; }

        public virtual event PrintDelegate SameSurname;
        
        protected virtual void OnEventHandler()
        {
            foreach (var item in persons)
            {
                if(item.Surname == guider)
                {
                    SameSurname(item.Name);
                }
            }
        }
        public Peoples()
        {
            persons = new();
        }

        public Peoples(List<Person> persons) 
        {
            this.persons = new List<Person>(persons);
        }
        
        public Peoples(List<Person> persons, string guider) : this(persons)
        {
            this.guider = guider;
        }

        public virtual void Add(Person person)
        {
            if (person.Surname == guider)
            {
                SameSurname(person.Name);
            }
            persons.Add(person);
        }
        public override string ToString()
        {
            string result = "";
            foreach (var item in persons)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }
    }
}
