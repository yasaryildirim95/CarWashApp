using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Concrete
{
    public class PersonelRepository : GenericRepository<Personel>
    {
        private DbSet<LoginDetail> loginDetails;
        private DbSet<PersonelLeave> personelLeaves;
        public PersonelRepository(DbContext dbContext) : base(dbContext)
        {
            loginDetails = dbContext.Set<LoginDetail>();
            personelLeaves = dbContext.Set<PersonelLeave>();
        }

        public (bool, bool) CheckLoginInfo(string username, string password)
        {
            var tempData = loginDetails.Where(p => p.Username == username && p.Password == password).FirstOrDefault();

            if (tempData != null)
            {
                return (true, tempData.IsAdmin);
            }
            return(false, false);
        }

        public bool AddUser(string name, string surname, int salary, int shiftId)
        {
            var newPersonel = new Personel()
            {
                Name = name,
                Surname = surname,
                Salary = salary,
                LeaveNum = 14,
                ShifTypeId = shiftId
            };

            Insert(newPersonel);
            return DbSet.Where(p => p.PersonelId == newPersonel.PersonelId).Any();     
        }

        public bool AddLoginDetails(int personelId, string username, string password)
        {
            var newLoginDetails = new LoginDetail()
            {
                PersonelId = personelId,
                Username = username,
                Password = password
            };

            loginDetails.Add(newLoginDetails);
            DbContext.SaveChanges();
            return loginDetails.Where(p => p.PersonelId == newLoginDetails.PersonelId).Any();
        }

        public bool AddPersonelLeave(int personelId, DateTime startDate, int dayCount)
        {
            var newPersonelLeave = new PersonelLeave()
            {
                PersonelId = personelId,
                StartDate = startDate,
                DayCount = dayCount
            };

            personelLeaves.Add(newPersonelLeave);
            DbContext.SaveChanges();
            return personelLeaves.Where(p => p.PersonelId == newPersonelLeave.PersonelId && p.StartDate == startDate).Any();
        }
    }
}
