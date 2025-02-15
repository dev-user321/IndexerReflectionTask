using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflectionTask.Models
{
    public class People
    {
        public int Id { get; set; }

        private Person[] people;

        public People(Person[] people)
        {
            this.people = people;
        }

        public Person this[int index]
        {
            get
            {
                return people[index];
            }
            set
            {
                people[index] = value;
            }
        }
    }
}
