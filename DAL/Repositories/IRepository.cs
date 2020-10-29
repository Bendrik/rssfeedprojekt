using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T:class
    {
        void Create(T entity);
        void Delete(int index);
        void Update(int index, T newEntity);
        List<T> GetAll();
        void SaveChanges();
        int GetIndexOfName(string name);
        int GetIndexOfCategory(string category);
    }
}
