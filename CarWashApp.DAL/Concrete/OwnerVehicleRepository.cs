using CarWashApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.DAL.Concrete
{
    public class OwnerVehicleRepository : GenericRepository<VehicleOwner>
    {
        private DbSet<Vehicle> vehicles;
        private DbSet<VehicleType> vehicleTypes;

        public OwnerVehicleRepository(DbContext dbContext) : base(dbContext)
        {
            vehicles = dbContext.Set<Vehicle>();
            vehicleTypes = dbContext.Set<VehicleType>();    
        }

        public bool SearchByPlate(string plate)
        {
            return vehicles.Where(v => v.Plate == plate).Any();
        }

        public bool AddOwner(string name, string surname, string phoneNumber, string email)
        {
            var newOwner = new VehicleOwner()
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber,
                Email = email,
            };
            Insert(newOwner);
            return DbSet.Where(o => o.PhoneNumber == phoneNumber).Any();
        }

        public bool AddVehicle(string phoneNumber, string plate, string brand, string model, string color, string vehicleTypeName) 
        { 
            var vehicleTypeIndex = vehicleTypes.Where(vt => vt.VehicleTypeName == vehicleTypeName).Select(vt => vt.VehicleTypeID).FirstOrDefault();
            var vehicleOwnerID = DbSet.Where(o => o.PhoneNumber == phoneNumber).Select(o => o.VehicleOwnerID).FirstOrDefault();

            var newVehicle = new Vehicle()
            {
                Plate = plate,
                Brand = brand,
                Model = model,
                Color = color,
                VehicleOwnerID = vehicleOwnerID,
                VehicleTypeID = vehicleTypeIndex
            };

            vehicles.Add(newVehicle);

            return vehicles.Where(v => v.Plate == plate).Any();

        }
    }
}
