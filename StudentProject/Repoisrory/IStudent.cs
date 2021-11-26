using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Repoisrory
{
  public  interface IStudent<T>
    {
        IList<T> GetAll();
        T Find(int id);
        void Add(T entity);
        void Delete(int id);
        void update(T etity);


    }
}
