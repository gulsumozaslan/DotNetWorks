using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6
{
    public interface IRepository<T>
    {
        void Add(string entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetList();
        T GetById(int id);

    }
}
