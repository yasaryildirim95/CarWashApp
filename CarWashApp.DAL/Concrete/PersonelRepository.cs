﻿using CarWashApp.Entity.Concrete;
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
            return(false, false);
        }
        public bool AddUser(string name, string surname, int salary, string shiftName, bool isWasher)
        {
            var shiftID = shifts.Where(s => s.ShiftName == shiftName).Select(s => s.ShiftTypeID).FirstOrDefault();

            var newPersonel = new Personel()
            {
                Name = name,
                Surname = surname,
                Salary = salary,
                LeavesLeft = 14,
                ShifTypeID = shiftID,
                IsWasher = isWasher,
                IsWorking = false
            };

            Insert(newPersonel);
            return DbSet.Where(p => p.Name == newPersonel.Name && p.Surname == newPersonel.Surname).Any();     
        }
        public bool AddLoginDetails(int personelId, string username, string password)
        {
            var newLoginDetails = new LoginDetail()
            {
                PersonelID = personelId,
                Username = username,
                Password = password
            };

            loginDetails.Add(newLoginDetails);
            DbContext.SaveChanges();
            return loginDetails.Where(p => p.PersonelID == newLoginDetails.PersonelID).Any();
        }
        public bool AddPersonelLeave(int personelId, DateTime startDate, int dayCount)
        {
            var query = DbSet.Where(p => p.PersonelID == personelId && p.LeavesLeft > dayCount);

            if (query.Any()) 
            {
                foreach (var item in query.ToList())
                {
                    item.LeavesLeft -= dayCount; 
                }
                var newPersonelLeave = new PersonelLeave()
                {
                    PersonelID = personelId,
                    StartDate = startDate,
                    NumOfDays = dayCount
                };

                personelLeaves.Add(newPersonelLeave);
                DbContext.SaveChanges();
                return personelLeaves.Where(p => p.PersonelID == newPersonelLeave.PersonelID && p.StartDate == startDate).Any();
            }
            return false; 
        }
    }
}