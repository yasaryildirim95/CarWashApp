using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Abstract;

namespace CarWashApp.BLL.Manager
{
    public class BaseManager<T> : IService<T> where T : class, IEntity
    {
        protected GenericRepository<T> _genericRepository;

        public BaseManager(GenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public virtual void Add(T entity)
        {
            _genericRepository.Insert(entity);
        }

        public void Delete(T entity)
        {
            _genericRepository.Delete(entity);
        }

        public List<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public T? GetById(int id)
        {
            return _genericRepository.Get(id);
        }

        public void Update(T entity)
        {
            _genericRepository.Update(entity);
        }
    }
}
