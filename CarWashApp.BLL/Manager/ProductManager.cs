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
    public class ProductManager : BaseManager<Product>, IProductService
    {
        protected ProductRepository _productRepository;

        public ProductManager(GenericRepository<Product> genericRepository, ProductRepository productRepository) : base(genericRepository)
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
