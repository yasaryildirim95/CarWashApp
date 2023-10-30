using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Concrete
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
            
        }

        public bool Add(string productName, int stock, int stockWarningThreshold)
        {
            //Name unique kılınmalı
            var newProduct = new Product()
            {
                ProductName = productName,
                Stock = stock,
                StockWarningThreshold = stockWarningThreshold
            };

            Insert(newProduct);

            return DbSet.Where(p => p.ProductName == productName && p.StockWarningThreshold == stockWarningThreshold).Any();
        }

        public bool Update(string productName, int stock, int stockWarningThreshlold)
        {
            var product = DbSet.Where(p => p.ProductName == productName).FirstOrDefault();

            if (product != null) 
            {
                product.Stock = stock;
                product.StockWarningThreshold = stockWarningThreshlold;

                Update(product);
            }
            
            return DbSet.Where(p => p.ProductName == productName && p.StockWarningThreshold == stockWarningThreshlold && p.Stock == stock).Any();
        }
    }
}
