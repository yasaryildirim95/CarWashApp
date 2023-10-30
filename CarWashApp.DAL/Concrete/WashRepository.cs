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
        private DbSet<DirtinessLevel> dirtinessLevels;
        private DbSet<WashType> washeTypes;
        private DbSet<Vehicle> vehicles;
        private DbSet<VehicleType> vehicleTypes;

        public WashRepository(DbContext dbContext) : base(dbContext)
        {
            washes = DbContext.Set<Wash>();
            vehicles = DbContext.Set<Vehicle>();
            dirtinessLevels = DbContext.Set<DirtinessLevel>();

        }

        public bool AddWash(int washTypeID, string plate, string dirtinessLevelName)
        {
            var vehicle = vehicles.Where(v => v.Plate == plate).FirstOrDefault();
            var washType = washeTypes.Where(w=>w.WashTypeID == washTypeID).FirstOrDefault();
            var vehicleType = vehicleTypes.Where(v=>v.VehicleTypeID == vehicle.VehicleTypeID).FirstOrDefault();
            var dirtinessLevel = dirtinessLevels.Where(v=>v.DirtinessLevelName == dirtinessLevelName).FirstOrDefault();

            Wash newWash = new Wash()
            {
                Price = washType.Price * vehicleType.PriceMultiplier,
                VehicleId = vehicle.VehicleID,
                WashTypeID = washTypeID,
                DirtinessLevelID = dirtinessLevel.DirtinessLevelID,
                StartTime = DateTime.Now,
                //EndTime = DateTime.Now.AddMinutes(washType.Duration + dirtinessLevel.AdditionalDuration) bu atama da personel aracı alınca yapılacak.
                //Personel ataması sonra yapılacak
            };
            
            washes.Add(newWash);
            
            return washes.Where(x=>x.WashID == newWash.WashID).Any();
        }

        //Timerda çalıştırılacak mevcut personellere boştaki araçları atama metodu - IsWasher dikkate alınarak:
    }
}
