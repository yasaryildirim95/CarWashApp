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
        public string AddWashTypeProduct(WashTypeProduct washTypeProduct)
        {
            try
            {
                if (_washTypeRepository.AddWashTypeProduct(washTypeProduct))
                {
                    return "Yıkama tipi ürünü eklendi";
                }
                return "Yıkama tipi ürünü eklenemedi";
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }

        public List<WashTypeProduct> GetAllWashTypeProducts()
        {
            return _washTypeRepository.GetAllWashTypeProducts();
        }
    }
}
