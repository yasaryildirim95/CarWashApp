using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Concrete
{
    public class WashRepository : GenericRepository<Wash> 
    {

        private DbSet<Wash> washes;
        private DbSet<DirtinessLevel> dirtinessLevel;
        private DbSet<WashType> washeTypes;
        private DbSet<Vehicle> vehicles;
        private DbSet<VehicleType> vehicleTypes;

        public WashRepository(DbContext dbContext) : base(dbContext)
        {
            washes = DbContext.Set<Wash>();
            vehicles = DbContext.Set<Vehicle>();

        }

        public IEnumerable<Wash> GetAllActiveWashes()
        {
            return washes
                .Include(w => w.Vehicle)
                .Include(w => w.WashType)
                .Include(w => w.Personel)
                .ToList();
        }

        public bool AddWash(int washtypeid,int vehicleid,int personelid,int dirtinessid)
        {
            var washtype = washeTypes.Where(w=>w.WashTypeId == washtypeid).FirstOrDefault();
            var vehicletype = vehicleTypes.Where(v=>v.VehicleTypeId == vehicleid).FirstOrDefault();

            Wash newWash = new Wash()
            {
                TotalPrice = washtype.Price*vehicletype.PriceMultiplier,
                PersonelId = personelid,
                VehicleId = vehicleid,
                WashType = washtype,
                DirtinessLevelId = dirtinessid,
                StartDate = DateTime.Now
            };
            washes.Add(newWash);
            return true;
            //return washes.Where(x=>x.StartDate == newWash.StartDate && ).Any();
        }
    }
}
