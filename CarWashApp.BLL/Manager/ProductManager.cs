using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Manager
{
    public class ProductManager : BaseManager<Product>, IProductService
    {
        protected ProductRepository _productRepository;

        public ProductManager(ProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public string Add(string productName, int stock, int stockWarningThreshold)
        {
            try
            {
                if(_productRepository.Add(productName, stock, stockWarningThreshold))
                {
                    return "Ürün eklendi.";
                }
                else
                {
                    return "Ürün eklenemedi.";
                }
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
        public string Update(string productName, int stock, int stockWarningThreshold)
        {
            try
            {
                if (_productRepository.Update(productName, stock, stockWarningThreshold))
                {
                    return "Ürün güncellendi.";
                }
                    return "Ürün güncellenemedi.";
                
            }
            catch
            {
                return "Veri tabanına ulaşım sırasında bir sıkıntı meydana geldi.";
            }
        }
    }
}
