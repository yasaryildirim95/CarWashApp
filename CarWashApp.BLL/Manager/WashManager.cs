using CarWashApp.BLL.Service;
using CarWashApp.DAL.Common;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Manager
{
    public class WashManager: BaseManager<Wash>, IWashService
    {
        protected WashRepository _washRepository;
        public WashManager(GenericRepository<Wash> genericRepository, WashRepository washRepository) : base(genericRepository)
        {
            _washRepository = washRepository;
        }

        public bool AddWash(string washTypeName, string plate, string dirtinessLevelName)
        {
            try
            {
                return _washRepository.AddWash(washTypeName, plate, dirtinessLevelName);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<DataGridStruct> RunCarWash()
        {
            try
            {
                return _washRepository.RunCarWash();
            }
            catch 
            { 
                return new List<DataGridStruct>(); 
            }
        }
    }
}
