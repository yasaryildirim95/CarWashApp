using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Concrete
{
    public class WashTypeRepository : GenericRepository<WashType>
    {
        DbSet<WashTypeProduct> washTypeProducts;
        DbSet<Product> products;

        public WashTypeRepository(DbContext dbContext) : base (dbContext)
        {
            washTypeProducts = dbContext.Set<WashTypeProduct>();
            products = dbContext.Set<Product>();
        }

        public bool Add(string washTypeName, int duration, int price, string productName, int quantity)
        {
            var productTypeID = products.Where(p => p.ProductName == productName).Select(p => p.ProductID).FirstOrDefault();
            //washtypeName unique olmalı
            var newWashType = new WashType()
            {
                WashTypeName = washTypeName,
                Duration = duration,
                Price = price
            };

            Insert(newWashType);

            newWashType = DbSet.Where(wt => wt.WashTypeName ==  washTypeName).FirstOrDefault();

            if(newWashType != null)
            {
                var newWashTypeProduct = new WashTypeProduct()
                {
                    WashTypeID = newWashType.WashTypeID,
                    ProductTypeID = productTypeID,
                    Quantity = quantity
                };
            }
            
            return washTypeProducts.Where(wtp => wtp.Quantity == quantity && wtp.ProductTypeID == productTypeID).Any();
        }
    }
}
