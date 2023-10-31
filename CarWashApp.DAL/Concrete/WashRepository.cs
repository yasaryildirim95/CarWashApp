using CarWashApp.DAL.Common;
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
        private DbSet<WashType> washTypes;
        private DbSet<Vehicle> vehicles;
        private DbSet<VehicleType> vehicleTypes;
        private DbSet<Personel> Personel;

        public WashRepository(DbContext dbContext) : base(dbContext)
        {
            washes = DbContext.Set<Wash>();
            vehicles = DbContext.Set<Vehicle>();
            dirtinessLevels = DbContext.Set<DirtinessLevel>();
            washTypes = DbContext.Set<WashType>();
            vehicleTypes = DbContext.Set<VehicleType>();
            Personel = DbContext.Set<Personel>();
        }

        public bool AddWash(int washTypeID, string plate, string dirtinessLevelName)
        {
            var vehicle = vehicles.Where(v => v.Plate == plate).FirstOrDefault();
            var washType = washTypes.Where(w=>w.WashTypeID == washTypeID).FirstOrDefault();
            var vehicleType = vehicleTypes.Where(v=>v.VehicleTypeID == vehicle.VehicleTypeID).FirstOrDefault();
            var dirtinessLevel = dirtinessLevels.Where(v=>v.DirtinessLevelName == dirtinessLevelName).FirstOrDefault();

            Wash newWash = new Wash()
            {
                Price = washType.Price * vehicleType.PriceMultiplier,
                VehicleId = vehicle.VehicleID,
                WashTypeID = washTypeID,
                DirtinessLevelID = dirtinessLevel.DirtinessLevelID,
                IsDone = false
                //Personel ataması sonra yapılacak
            };
            
            washes.Add(newWash);
            
            return washes.Where(x=>x.WashID == newWash.WashID).Any();
        }

        public List<DataGridStruct> ListWashes()
        {
            AssignPersonel();

            var mainList = DbSet.Include(w => w.WashType).Include(w => w.Personel).Include(w => w.DirtinessLevel).Include(w => w.Vehicle).ToList();

            var outputList = new List<DataGridStruct>();

            var queueNum = 1;

            foreach (var wash in mainList)
            {
                outputList.Add(new DataGridStruct

                {
                    SIRA = queueNum,
                    PLAKA = wash.Vehicle.Plate,
                    MARKA = wash.Vehicle.Brand,
                    MODEL = wash.Vehicle.Model,
                    YIKAMA_TİPİ = wash.WashType.WashTypeName,
                    ÇALIŞAN_KİŞİ = wash.PersonelID >= 1 ? wash.Personel.Name : "Çalışan Bekleniyor.",
                    YIKAMA_DURUMU = (!wash.IsDone && wash.PersonelID < 1) ? "Sırada" : ((wash.EndTime - DateTime.Now).Minutes > 0) ? "İşlemde." : "Bitti.",
                    KALAN_SÜRE = (wash.EndTime - DateTime.Now).Minutes > 0 ? (wash.EndTime - DateTime.Now).Minutes : 0
                });

                queueNum++;
            }

            //Tamam olup olmadığını kontrol et yıkamanın - sanıyorum ki burada.

            return outputList;  
        }

        public void AssignPersonel()
        {
            var personel = Personel.Where(p => p.IsWasher == true && p.IsWorking == false).ToList();
            var washes = DbSet.Include(w => w.WashType).Include(w => w.DirtinessLevel).Where(w => w.PersonelID < 1).ToList();

            foreach (var person in personel)
            {
                var wash = washes.Where(w => w.PersonelID < 1).FirstOrDefault();
                if(wash != null)
                {
                    wash.PersonelID = person.PersonelID;
                    wash.EndTime = DateTime.Now.AddMinutes(wash.DirtinessLevel.AdditionalDuration + wash.WashType.Duration);
                    person.IsWorking = true;
                }
                DbContext.SaveChanges();
            }
        }

        //Timerda çalıştırılacak mevcut personellere boştaki araçları atama metodu - IsWasher dikkate alınarak:
    }
}
