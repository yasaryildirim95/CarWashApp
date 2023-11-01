using CarWashApp.DAL.Common;
using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

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

        public bool AddWash(string washTypeName, string plate, string dirtinessLevelName)
        {
            var vehicle = vehicles.Where(v => v.Plate == plate).FirstOrDefault();
            var washType = washTypes.Where(w => w.WashTypeName == washTypeName).FirstOrDefault();
            var vehicleType = vehicleTypes.Where(v => v.VehicleTypeID == vehicle.VehicleTypeID).FirstOrDefault();
            var dirtinessLevel = dirtinessLevels.Where(v => v.DirtinessLevelName == dirtinessLevelName).FirstOrDefault();

            Wash newWash = new Wash()
            {
                Price = washType.Price * vehicleType.PriceMultiplier,
                VehicleId = vehicle.VehicleID,
                WashTypeID = washType.WashTypeID,
                DirtinessLevelID = dirtinessLevel.DirtinessLevelID,
                IsDone = false
                //Personel ataması sonra yapılacak
            };

            washes.Add(newWash);

            return washes.Where(x => x.WashID == newWash.WashID).Any();
        }

        public List<DataGridStruct> RunCarWash()
        {
            AssignPersonel();

            CheckWashes();

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
                    ÇALIŞAN_KİŞİ = wash.Personel != null ? wash.Personel.Name : "Çalışan Bekleniyor.",
                    YIKAMA_DURUMU = (!wash.IsDone && wash.Personel == null) ? "Sırada" : ((wash.EndTime - DateTime.Now).Minutes > 0) ? "İşlemde." : "Bitti.",
                    KALAN_SÜRE = (wash.EndTime - DateTime.Now).Minutes > 0 ? (wash.EndTime - DateTime.Now).Minutes : 0
                });

                queueNum++;
            }

            return outputList;
        }

        private void CheckWashes()
        {
            var list = DbSet.Include(w => w.Personel).ToList();

            if (list.Count() > 1)
            {
                foreach (var wash in list.Where(w => w.IsDone == false && w.Personel != null && w.EndTime < DateTime.Now))
                {
                    var currentWash = DbSet.Where(w => w.WashID == wash.WashID).FirstOrDefault();
                    currentWash.IsDone = true;
                    currentWash.Personel.IsWorking = false;

                    DbContext.SaveChanges();
                }
            }
        }

        public void AssignPersonel()
        {
            var personel = Personel.Where(p => p.IsWasher == true && p.IsWorking == false).ToList();
            var washes = DbSet.Include(w => w.WashType).Include(w => w.DirtinessLevel).Where(w => w.Personel == null).ToList();

            if (washes.Count > 0)
                foreach (var person in personel)
                {
                    var wash = washes.FirstOrDefault();
                    if (wash != null)
                    {
                        wash.PersonelID = person.PersonelID;
                        wash.EndTime = DateTime.Now.AddMinutes(wash.DirtinessLevel.AdditionalDuration + wash.WashType.Duration);
                        person.IsWorking = true;

                        DbContext.SaveChanges();
                    }
                }
        }
    }
}
