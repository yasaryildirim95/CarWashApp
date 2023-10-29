using CarWashApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(int id);
        List<T> GetAll();
    }
}
