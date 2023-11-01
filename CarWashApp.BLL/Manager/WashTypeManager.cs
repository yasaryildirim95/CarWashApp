using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Manager
{
    public class WashTypeManager : BaseManager<WashType>, IWashTypeService
    {
        protected WashTypeRepository _washTypeRepository;
        public WashTypeManager(GenericRepository<WashType> genericRepository, WashTypeRepository washTypeRepository) : base(genericRepository)
        {
            _washTypeRepository = washTypeRepository;
        }

        public bool Add(string washTypeName, int duration, int price, int usage, params string[] productNames)
        {
            try
            {
                return _washTypeRepository.Add(washTypeName, duration, price, usage, productNames);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
