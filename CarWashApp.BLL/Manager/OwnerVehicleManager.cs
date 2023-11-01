using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashApp.BLL.Manager
{
    public class OwnerVehicleManager : BaseManager<VehicleOwner>, IOwnerVehicleService
    {
        protected OwnerVehicleRepository _ownerVehicleRepository;

        public OwnerVehicleManager(GenericRepository<VehicleOwner> genericRepository, OwnerVehicleRepository ownerVehicleRepository) : base(genericRepository)
        {
            _ownerVehicleRepository = ownerVehicleRepository;
        }

        public bool SearchByPlate(string plate)
        {
            try
            {
                return _ownerVehicleRepository.SearchByPlate(plate);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddOwner(string name, string surname, string phoneNumber, string email)
        {
            try
            {
                return _ownerVehicleRepository.AddOwner(name, surname, phoneNumber, email);
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool AddVehicle(string phoneNumber, string plate, string brand, string model, string color, string vehicleTypeName)
        {
            try
            {
                return _ownerVehicleRepository.AddVehicle(phoneNumber, plate, brand, model, color, vehicleTypeName);
            }
            catch (Exception)
            {

                return false;
            } 
        }
    }
}
