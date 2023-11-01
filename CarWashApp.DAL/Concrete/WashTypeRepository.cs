using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarWashApp.DAL.Concrete
{
    public class WashTypeRepository : GenericRepository<WashType>
    {
        DbSet<WashTypeProduct> washTypeProducts;
        DbSet<Product> products;

        public WashTypeRepository(DbContext dbContext) : base(dbContext)
        {
            washTypeProducts = dbContext.Set<WashTypeProduct>();
            products = dbContext.Set<Product>();
        }

        public bool Add(string washTypeName, int duration, int price, int usage, params string[] productNames)
        {
            //washtypeName unique olmalı
            var newWashType = new WashType()
            {
                WashTypeName = washTypeName,
                Duration = duration,
                Price = price
            };

            Insert(newWashType);

            newWashType = DbSet.Where(wt => wt.WashTypeName == washTypeName).FirstOrDefault();

            if (newWashType != null)
            {
                for (int i = 0; i < productNames.Length; i++)
                {
                    var productTypeID = products.Where(p => p.ProductName == productNames[i]).Select(p => p.ProductID).FirstOrDefault();

                    var newWashTypeProduct = new WashTypeProduct()
                    {
                        WashTypeID = newWashType.WashTypeID,
                        ProductTypeID = productTypeID,
                        Quantity = usage
                    };

                    washTypeProducts.Add(newWashTypeProduct);
                }

                DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
