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

        public string AddWash(string washTypeName, string plate, string dirtinessLevelName)
        {
            try
            {
                if(_washRepository.AddWash(washTypeName, plate, dirtinessLevelName))
                {
                    return "Yıkama eklendi.";
                }
                else
                {
                    return "Yıkama eklenemedi.";
                }
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
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
