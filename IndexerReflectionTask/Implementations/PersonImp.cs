using IndexerReflectionTask.Interface;
using IndexerReflectionTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflectionTask.Implementations
{
    public class PersonImp : IPerson<Person>
    {
        List<Person> persons = new List<Person>();
        public void Add(Person person)
        {
            persons.Add(person);
        }

        public void AddRange(List<Person> newPerson)
        {
             if (newPerson == null)
                throw new ArgumentNullException(nameof(newPerson));

            persons.AddRange(newPerson);
        }

        public void Clear(int id)
        {
            persons.Remove(FindById(id));
        }

        public Person FindById(int id)
        {
            return persons.Find(x => x.Id == id);
        }

        public List<Person> GetAll()
        {
            return persons;
        }
    }
}
