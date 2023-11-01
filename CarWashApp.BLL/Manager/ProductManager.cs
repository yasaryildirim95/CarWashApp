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

        public bool Add(string productName, int stock, int stockWarningThreshold)
        {
            try
            {
                return _productRepository.Add(productName, stock, stockWarningThreshold);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(string productName, int stock, int stockWarningThreshold)
        {
            try
            {
                return _productRepository.Update(productName, stock, stockWarningThreshold);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
