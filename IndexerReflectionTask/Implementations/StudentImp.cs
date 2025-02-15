using IndexerReflectionTask.Interface;
using IndexerReflectionTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflectionTask.Implementations
{
    public class StudentImp : IStudent
    {
        List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public void AddRange(List<Student> newStudents)
        {
            if (newStudents == null)
                throw new ArgumentNullException(nameof(newStudents));

            students.AddRange(newStudents);
        }

        public void Clear(int id)
        {
            students.Remove(FindById(id));
        }


        public Student FindById(int id)
        {
            return students.Find(x => x.Id == id);
        }

        public List<Student> GetAll()
        {
            return students;
        }
    }
}
