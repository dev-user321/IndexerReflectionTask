using IndexerReflectionTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReflectionTask.Interface
{
    public interface IPerson<T>
    {
        List<T> GetAll();
        void Add (T t);
        void Clear(int id); 
        void AddRange(List<T> t);
        T FindById(int id);

    }
}
