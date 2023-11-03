using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarWashApp.DAL.Concrete
{
    public class PersonelRepository : GenericRepository<Personel>
    {
        private DbSet<LoginDetail> loginDetails;
        private DbSet<PersonelLeave> personelLeaves;
        private DbSet<Shift> shifts;

        public PersonelRepository(DbContext dbContext) : base(dbContext)
        {
            loginDetails = dbContext.Set<LoginDetail>();
            personelLeaves = dbContext.Set<PersonelLeave>();
            shifts = dbContext.Set<Shift>();
        }

        public (bool, bool) CheckLoginInfo(string username, string password)
        {
            var tempData = loginDetails.Where(p => p.Username == username && p.Password == password).FirstOrDefault();

            if (tempData != null)
            {
                return (true, tempData.IsAdmin);
            }
            return (false, false);
        }
        public bool AddUser(string name, string surname, int salary, int shiftTypeId, bool isWasher)
        {
            //var shiftID = shifts.Where(s => s.ShiftName == shiftName).Select(s => s.ShiftTypeID).FirstOrDefault();

            var newPersonel = new Personel()
            {
                Name = name,
                Surname = surname,
                Salary = salary,
                LeavesLeft = 14,
                ShifTypeID = shiftTypeId,
                IsWasher = isWasher,
                IsWorking = false
            };
            Insert(newPersonel);
            return DbSet.Where(p => p.Name == newPersonel.Name && p.Surname == newPersonel.Surname).Any();
        }
        public bool AddLoginDetails(int personelId, string username, string password, bool IsAdmin)
        {
            if (!loginDetails.Where(ld => ld.PersonelID == personelId).Any())
            {
                var newLoginDetails = new LoginDetail()
                {
                    PersonelID = personelId,
                    Username = username,
                    Password = password,
                    IsAdmin = IsAdmin
                };
                loginDetails.Add(newLoginDetails);
                DbContext.SaveChanges();
                return loginDetails.Where(p => p.PersonelID == newLoginDetails.PersonelID).Any();
            }
            return false;

        }
        public bool AddPersonelLeave(PersonelLeave pl)
        {
            if (DbSet.Where(p => p.PersonelID == pl.PersonelID && p.LeavesLeft > pl.NumOfDays).Any())
            {
                DbSet.Where(p => p.PersonelID == pl.PersonelID).First().LeavesLeft -= pl.NumOfDays;

                personelLeaves.Add(pl);

                DbContext.SaveChanges();
                return personelLeaves.Where(p => p.PersonelID == pl.PersonelID && p.StartDate == pl.StartDate).Any();
            }
            return false;
        }
        public List<Personel> GetAll(int temp)
        {
            var List = loginDetails.Select(x => x.PersonelID).ToList();
            List<Personel> personels = new List<Personel>();
            foreach (var i in DbSet.ToList())
            {
                if (!List.Contains(i.PersonelID))
                    personels.Add(i);
            }
            return personels;
        }

        public List<PersonelLeave> GetAllPersonelLeaves()
        {
            var list = personelLeaves.ToList();
            return list;
        }
    }
}
