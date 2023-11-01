using CarWashApp.BLL.Service;
using CarWashApp.DAL.Common;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Manager
{
    public class WashManager : BaseManager<Wash>, IWashService
    {
        protected WashRepository _washRepository;
        public WashManager(WashRepository washRepository) : base(washRepository)
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
