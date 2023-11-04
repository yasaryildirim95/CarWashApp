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
            if (!DbSet.Include(w => w.Vehicle).Where(w => w.Vehicle.Plate == plate && w.IsDone == false).Any())
            {
                var vehicle = vehicles.Where(v => v.Plate == plate).FirstOrDefault();
                var washType = washTypes.Where(w => w.WashTypeName == washTypeName).FirstOrDefault();
                var vehicleType = vehicleTypes.Where(v => v.VehicleTypeID == vehicle.VehicleTypeID).FirstOrDefault();
                var dirtinessLevel = dirtinessLevels.Where(v => v.DirtinessLevelName == dirtinessLevelName)
                    .FirstOrDefault();

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
                DbContext.SaveChanges();
                return washes.Where(x => x.WashID == newWash.WashID).Any();
            }

            return false;
        }

        public bool UpdateWash(int id, string washTypeName, string plate, string dirtinessLevelName)
        {
            var currentWash = DbSet.Include(w => w.DirtinessLevel).Include(w => w.WashType).Include(w => w.Vehicle)
                .ThenInclude(w => w.VehicleType).Where(w => w.WashID == id).FirstOrDefault();

            var vehicle = vehicles.Include(v => v.VehicleType).Where(v => v.Plate == plate).FirstOrDefault();
            var washType = washTypes.Where(w => w.WashTypeName == washTypeName).FirstOrDefault();
            var dirtinessLevel = dirtinessLevels.Where(v => v.DirtinessLevelName == dirtinessLevelName)
                .FirstOrDefault();

            currentWash.Price = washType.Price * vehicle.VehicleType.PriceMultiplier;
            currentWash.VehicleId = vehicle.VehicleID;
            currentWash.WashTypeID = washType.WashTypeID;
            currentWash.DirtinessLevelID = dirtinessLevel.DirtinessLevelID;

            var currentPersonel = Personel.Where(p => p.PersonelID == currentWash.PersonelID).FirstOrDefault();

            if (currentPersonel != null)
            {
                currentPersonel.IsWorking = false;
            }

            currentWash.PersonelID = null;


            DbContext.SaveChanges();

            return DbSet.Include(w => w.DirtinessLevel).Include(w => w.WashType).Include(w => w.Vehicle).Where(w =>
                w.WashID == id && w.WashTypeID == washType.WashTypeID &&
                w.Vehicle.VehicleTypeID == vehicle.VehicleTypeID &&
                w.DirtinessLevelID == dirtinessLevel.DirtinessLevelID).Any();
        }

        public bool DeleteByID(int id)
        {
            var wash = DbSet.Where(w => w.WashID == id).FirstOrDefault();

            if (wash != null) Delete(wash);

            return !DbSet.Where(w => w.WashID == id).Any();
        }

        public List<DataGridStruct> RunCarWash()
        {
            AssignPersonel();

            CheckWashes();

            var mainList = DbSet.Include(w => w.WashType).Include(w => w.Personel).Include(w => w.DirtinessLevel)
                .Include(w => w.Vehicle).ToList();

            var outputList = new List<DataGridStruct>();

            var queueNum = 1;

            foreach (var wash in mainList)
            {
                outputList.Add(new DataGridStruct
                {
                    SIRA = queueNum,
                    YIKAMA_ID = wash.WashID,
                    PLAKA = wash.Vehicle.Plate,
                    MARKA = wash.Vehicle.Brand,
                    MODEL = wash.Vehicle.Model,
                    YIKAMA_TİPİ = wash.WashType.WashTypeName,
                    ÇALIŞAN_KİŞİ = wash.Personel != null
                        ? wash.Personel.Name + " " + wash.Personel.Surname
                        : "Çalışan Bekleniyor.",
                    YIKAMA_DURUMU = (!wash.IsDone && wash.Personel == null) ? "Sırada" :
                        ((wash.EndTime - DateTime.Now).Minutes > 0) ? "İşlemde." : "Bitti.",
                    KALAN_SÜRE = (wash.EndTime - DateTime.Now).Minutes > 0
                        ? (wash.EndTime - DateTime.Now).Minutes
                        : 0
                });

                queueNum++;
            }

            return outputList;
        }

        private void CheckWashes()
        {
            var list = DbSet.Include(w => w.Personel)
                .Where(w => w.IsDone == false && w.Personel != null && w.EndTime < DateTime.Now).ToList();

            if (list.Count() > 0)
            {
                foreach (var wash in list)
                {
                    var currentWash = DbSet.Where(w => w.WashID == wash.WashID).First();
                    currentWash.IsDone = true;
                    currentWash.Personel.IsWorking = false;

                    DbContext.SaveChanges();
                }
            }
        }

        public void AssignPersonel()
        {
            var personel = Personel.Where(p => p.IsWasher == true && p.IsWorking == false).ToList();

            if (personel.Count() > 0)
            {
                foreach (var person in personel)
                {
                    var wash = DbSet.Include(w => w.DirtinessLevel).Include(w => w.WashType)
                        .Where(w => w.Personel == null).FirstOrDefault();

                    if (wash != null)
                    {
                        wash.PersonelID = person.PersonelID;
                        wash.EndTime =
                            DateTime.Now.AddMinutes(wash.DirtinessLevel.AdditionalDuration +
                                                    wash.WashType.Duration);
                        Personel.Where(p => p.PersonelID == person.PersonelID).First().IsWorking = true;

                        DbContext.SaveChanges();
                    }
                }
            }
        }
    }
}

