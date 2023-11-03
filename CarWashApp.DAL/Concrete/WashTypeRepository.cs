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

        public bool AddWashTypeProduct(WashTypeProduct washTypeProduct)
        {
            if (!washTypeProducts.Where(wtp => wtp.WashTypeID == washTypeProduct.WashTypeID && wtp.ProductTypeID == washTypeProduct.ProductTypeID).Any())
            {
                washTypeProducts.Add(washTypeProduct);
                DbContext.SaveChanges();
                return washTypeProducts.Where(wtp => wtp.WashTypeID == washTypeProduct.WashTypeID && wtp.ProductTypeID == washTypeProduct.ProductTypeID).Any();
            }
            return false;
        }

        public List<WashTypeProduct> GetAllWashTypeProducts()
        {
            return washTypeProducts.Include(x => x.WashType).Include(x => x.Product).ToList();
        }
    }
}
