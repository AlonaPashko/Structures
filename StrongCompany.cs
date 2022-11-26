using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class StrongCompany : Peoples
    {
        public StrongCompany() : base() { }

        public StrongCompany(List<Person> persons) : base(persons) { }

        public StrongCompany(List<Person> persons, string guider) : base(persons, guider) { }

        public override event PrintDelegate SameSurname;

        public override void Add(Person person)
        {
            if (person.Surname == guider)
            {
                SameSurname(person.Name);
            }
            persons.Add(person);
        }
    }
}
