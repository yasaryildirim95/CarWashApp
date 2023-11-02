using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Manager
{
    public class WashTypeManager : BaseManager<WashType>, IWashTypeService
    {
        protected WashTypeRepository _washTypeRepository;
        public WashTypeManager(WashTypeRepository washTypeRepository) : base(washTypeRepository)
        {
            _washTypeRepository = washTypeRepository;
        }

        public string Add(string washTypeName, int duration, int price, int usage, params string[] productNames)
        {
            try
            {
                if(_washTypeRepository.Add(washTypeName, duration, price, usage, productNames))
                {
                    return "Yıkama tipi eklendi";
                }
                return "Yıkama tipi eklenemedi";
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
    }
}
