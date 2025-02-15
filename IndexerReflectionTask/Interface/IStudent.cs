using IndexerReflectionTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflectionTask.Interface
{
    public interface IStudent
    {
        List<Student> GetAll();
        void Add (Student student);
        void Clear(int id); 
        void AddRange(List<Student> students);
        Student FindById(int id);

    }
}
