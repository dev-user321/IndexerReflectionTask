using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflectionTask.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UniversityName { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{LastName},{UniversityName}";
        }
    }
}
