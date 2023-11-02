using CarWashApp.DAL.Abstract;
using CarWashApp.Entity.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CarWashApp.DAL.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public GenericRepository(DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            DbContext.Remove(entity);
            DbContext.SaveChanges();
        }

        public T Get(int id) => DbContext.Set<T>().Find(id);

        public virtual List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public void Insert(T entity)
        {
            DbSet.Add(entity);
            DbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
